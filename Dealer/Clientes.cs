using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dealer
{
    class Clientes
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public Clientes() { }
        public Clientes(string c, string n, string a, string t)
        {
            this.codigo = c;
            this.nombre = n;
            this.apellido = a;
            this.telefono = t;
        }

        public static int Registrar(Clientes c)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into clientes(nombre, apellido, telefono) values('{0}', '{1}', '{2}')", c.nombre, c.apellido, c.telefono), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int Modificar(Clientes c)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("update clientes set nombre = '{0}', apellido = '{1}', telefono = '{2}' where codigo = {3}", c.nombre, c.apellido, c.telefono, c.codigo), con);
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
                SqlCommand comand = new SqlCommand(string.Format("delete clientes where codigo = {0}", codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static Clientes getClientes(string codigo)
        {
            Clientes c = new Clientes();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(String.Format("select * from clientes where codigo = {0}", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        c.codigo = re["codigo"].ToString();
                        c.nombre = re["nombre"].ToString();
                        c.apellido = re["apellido"].ToString();
                        c.telefono = re["telefono"].ToString();
                    }
                }
                else
                {
                    c = null;
                }
                con.Close();
            }
            return c;
        }
        public static List<Clientes> Buscar(string codigo, string nombre, string apellido, string telefono)
        {
            List<Clientes> list = new List<Clientes>();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from clientes where codigo like '{0}%' and nombre like '{1}%' and apellido like '{2}%' and telefono like '{3}%'", codigo, nombre, apellido, telefono), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Clientes c = new Clientes();
                    c.codigo = re["codigo"].ToString();
                    c.nombre = re["nombre"].ToString();
                    c.apellido = re["apellido"].ToString();
                    c.telefono = re["telefono"].ToString();

                    list.Add(c);
                }
                con.Close();
            }
            return list;
        }
    }
}
