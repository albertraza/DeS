using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dealer
{
    class Automoviles
    {
        public string codigo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string year { get; set; }
        public string precio { get; set; }
        public string cilindros { get; set; }
        public string imagen { get; set; }

        public Automoviles() { }
        public Automoviles(string co, string ma, string mo, string ye, string pre, string ci, string im)
        {
            this.codigo = co;
            this.marca = ma;
            this.modelo = mo;
            this.year = ye;
            this.precio = precio;
            this.cilindros = ci;
            this.imagen = im;
        }

        public static int Registrar(Automoviles a, string cantExistencia, string suplidor)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into automoviles (marca, modelo, ano, precio, numcilindros, CantExistente, imagen, suplidor) values ('{0}', '{1}', '{2}', '{3}','{4}' ,'{5}', '{6}', '{7}')", 
                    a.marca, a.modelo, a.year, a.precio, a.cilindros , cantExistencia, a.imagen, suplidor), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int Modificar(Automoviles a, string CantExistente, string suplidor)
        {
            int r = -1;
            using(SqlConnection con = ConnectionDB.conectar()){
                SqlCommand comand = new SqlCommand(string.Format("update automoviles set marca = '{0}', modelo = '{1}', ano = '{2}', precio = '{3}', numcilindros = '{4}', CantExistente = '{5}', imagen = '{6}', suplidor = '{7}' where codigo = '{8}'",
                    a.marca, a.modelo, a.year, a.precio, a.cilindros, CantExistente, a.imagen, suplidor, a.codigo), con);
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
                SqlCommand comand = new SqlCommand("delete automoviles where codigo = '" + codigo + "'", con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static Automoviles getAutomovil(string codigo)
        {
            Automoviles A = new Automoviles();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from automoviles where codigo = {0}", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        A.codigo = re["codigo"].ToString();
                        A.cilindros = re["numcilindros"].ToString();
                        A.imagen = re["imagen"].ToString();
                        A.marca = re["marca"].ToString();
                        A.modelo = re["modelo"].ToString();
                        A.precio = re["precio"].ToString();
                        A.year = re["ano"].ToString();
                    }
                }
                else
                {
                    A = null;
                }
                con.Close();
            }
            return A;
        }
        public static string getSuplidor(int codigo)
        {
            string r = null;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select suplidor from automoviles where codigo = {0}", codigo), con);
                r = comand.ExecuteScalar().ToString();
                con.Close();
            }
            return r;
        }
        public static string getCantExistente(int codigo)
        {
            string r = null;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select CantExistente from automoviles where codigo = {0}", codigo), con);
                r = comand.ExecuteScalar().ToString();
                con.Close();
            }
            return r;
        }
        public static List<Automoviles> Buscar(string codigo, string marcaa, string modelo, string year, string numcilindros, string suplidor)
        {
            List<Automoviles> list = new List<Automoviles>();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("Select * from automoviles where codigo like '{0}%' and marca like '{1}%' and modelo like '{2}%' and ano like '{3}%'and numcilindros like '{4}%'and suplidor like '{5}%'", codigo, marcaa, modelo, year, numcilindros, suplidor), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Automoviles u = new Automoviles();
                    u.codigo = re["codigo"].ToString();
                    u.cilindros = re["numcilindros"].ToString();
                    u.imagen = re["imagen"].ToString();
                    u.marca = re["marca"].ToString();
                    u.modelo = re["modelo"].ToString();
                    u.precio = re["precio"].ToString();
                    u.year = re["ano"].ToString();

                    list.Add(u);
                }
            }
            return list;
        }
        public static int ActualizarCantExistente(string codigo, string cantexistente)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("update automoviles set CantExistente = '{0}' where codigo = '{1}'", cantexistente, codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
    }
}
