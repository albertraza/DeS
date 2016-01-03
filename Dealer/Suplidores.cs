using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dealer
{
    class Suplidores
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public string telefono { get; set; }

        public Suplidores() { }
        public Suplidores(string co, string no, string di, string des, string im, string t)
        {
            this.codigo = co;
            this.nombre = no;
            this.direccion = di;
            this.descripcion = des;
            this.imagen = im;
            this.telefono = t;
        }

        public static int Registrar(Suplidores s)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into suplidores (nombresuplidor, direccion, descripcion, imagen, telefono) values ('{0}', '{1}', '{2}', '{3}', '{4}')", s.nombre, s.direccion, s.descripcion, s.imagen, s.telefono), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int Modificar(Suplidores s)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("update suplidores set nombresuplidor = '{0}', direccion = '{1}', descripcion = '{2}', imagen = '{3}', telefono = '{4}' where codigo = '{5}'", s.nombre, s.direccion, s.descripcion, s.imagen, s.telefono, s.codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int Eliminar(string codigo)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("delete suplidores where codigo = {0}", codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static List<Suplidores> Buscar(string nombre, string direccion, string telefono, string codigo)
        {
            List<Suplidores> list = new List<Suplidores>();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from suplidores where codigo like '{0}%' and nombresuplidor like '{1}%' and telefono like '{2}%' and direccion like '{3}%'",
                    codigo, nombre, telefono, direccion), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Suplidores s = new Suplidores();
                    s.codigo = re["codigo"].ToString();
                    s.descripcion = re["descripcion"].ToString();
                    s.direccion = re["direccion"].ToString();
                    s.imagen = re["imagen"].ToString();
                    s.nombre = re["nombresuplidor"].ToString();
                    s.telefono = re["telefono"].ToString();

                    list.Add(s);
                }
                con.Close();
            }
            return list;
        }
        public static Suplidores getSuplidor(string codigo)
        {
            Suplidores s = new Suplidores();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from suplidores where codigo = {0}", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        s.codigo = re["codigo"].ToString();
                        s.descripcion = re["descripcion"].ToString();
                        s.direccion = re["direccion"].ToString();
                        s.imagen = re["imagen"].ToString();
                        s.nombre = re["nombresuplidor"].ToString();
                        s.telefono = re["telefono"].ToString();
                    }
                }
                else
                {
                    s = null;
                }
                con.Close();
            }
            return s;
        }
    }
}
