using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dealer
{
    class Usuario
    {
        public string codigo { get; set; }
        public string ID_Usuario { get; set; }


        public Usuario(){}
        public Usuario(string c, string id)
        {
            this.codigo = c;
            this.ID_Usuario = id;
        }

        public static String ImagenUsr(string idusuario)
        {
            string r = null;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select imagen from usuarios where id_usuario = '{0}'", idusuario), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        r = re["imagen"].ToString();
                    }
                }
                else
                {
                    r = null;
                }
                con.Close();
            }
            return r;
        }
        public static int Registrar(string idusuario, string imagen, string clave)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into usuarios (id_usuario, pass, imagen) values ('{0}', '{1}', '{2}')", idusuario, clave, imagen), con);
                r = comand.ExecuteNonQuery();
                con.Close(); ;
            }
            return r;
        }
        public static int Actualizar(string usuario, string imagen, string clave, string codigo)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("update usuarios set id_usuario = '{0}', pass = '{1}', imagen = '{2}' where codigo = {3}", usuario, clave, imagen, codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static bool Login(Usuario u, string clave)
        {
            bool r = false;
            using(SqlConnection con = ConnectionDB.conectar()){
                SqlCommand comand = new SqlCommand(string.Format("select * from usuarios where id_usuario = '{0}' and pass = '{1}'", u.ID_Usuario, clave), con);
                SqlDataReader re = comand.ExecuteReader();
                if(re.HasRows){
                    r = true;
                }
                else
                {
                    r = false;
                }
                con.Close();
            }
            return r;
        }
        public static Usuario getUsuario(string codigo)
        {
            Usuario u = new Usuario();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from usuarios where codigo = {0}", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        u.codigo = re["codigo"].ToString();
                        u.ID_Usuario = re["id_usuario"].ToString();
                    }
                }
                else
                {
                    u = null;
                }
                con.Close();
            }
            return u;
        }
        public static String ImagenUsrCod(string codigo)
        {
            string r = null;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select imagen from usuarios where codigo = '{0}'", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        r = re["imagen"].ToString();
                    }
                }
                else
                {
                    r = null;
                }
                con.Close();
            }
            return r;
        }
        public static int Eliminar(string codigo)
        {
            int r = -1;
            using(SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("delete usuarios where codigo = {0}", codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static List<Usuario> Buscar(string codigo, string idusuario)
        {
            List<Usuario> list = new List<Usuario>();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from Usuarios where codigo like '{0}%' and id_usuario like '{1}%'", codigo, idusuario), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Usuario u = new Usuario();
                    u.codigo = re["codigo"].ToString();
                    u.ID_Usuario = re["id_usuario"].ToString();

                    list.Add(u);
                }
                con.Close();
            }
            return list;
        }
    }
}
