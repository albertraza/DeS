using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dealer
{
    class Ventas
    {
        public string codigo { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Carro_Comprado { get; set; }
        public string Precio_Und { get; set; }
        public string Cant_Comprada { get; set; }
        public string Total_pagar { get; set; }

        public Ventas() { }

        public Ventas(string co, string nc, string cc, string pu, string cco, string tp)
        {
            this.codigo = co;
            this.Nombre_Cliente = nc;
            this.Precio_Und = pu;
            this.Carro_Comprado = cc;
            this.Cant_Comprada = cco;
            this.Total_pagar = tp;
        }

        public static int Registrar(Ventas v, string codigoauto)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("insert into ventas (nombrecliente, carrocomprado, preciound, cantcomprada, totalpagar, codigoauto) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", v.Nombre_Cliente, v.Carro_Comprado, v.Precio_Und, v.Cant_Comprada, v.Total_pagar, codigoauto), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static int Modificar(Ventas v)
        {
            int r = -1;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("update ventas set nombrecliente = '{0}', carrocomprado = '{1}', preciound = '{2}', cantcomprada = '{3}', totalpagar = '{4}' where codigo = '{5}'", v.Nombre_Cliente, v.Carro_Comprado, v.Precio_Und, v.Cant_Comprada, v.Total_pagar, v.codigo), con);
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
                SqlCommand comand = new SqlCommand(string.Format("delete ventas where codigo = {0}", codigo), con);
                r = comand.ExecuteNonQuery();
                con.Close();
            }
            return r;
        }
        public static List<Ventas> Buscar(string nombrecliente, string carrocomprado, string preciound, string cantcomprada, string totalpagar, string codigo)
        {
            List<Ventas> list = new List<Ventas>();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from ventas where codigo like '{0}%' and nombrecliente like '{1}%' and preciound like '{2}%' and totalpagar like '{3}%' and carrocomprado like '{4}%'", codigo, nombrecliente, preciound, totalpagar, carrocomprado), con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    Ventas v = new Ventas();
                    v.codigo = re["codigo"].ToString();
                    v.Cant_Comprada = re["cantcomprada"].ToString();
                    v.Carro_Comprado = re["carrocomprado"].ToString();
                    v.Nombre_Cliente = re["nombrecliente"].ToString();
                    v.Precio_Und = re["preciound"].ToString();
                    v.Total_pagar = re["totalpagar"].ToString();

                    list.Add(v);
                }
                con.Close();
            }
            return list;
        }
        public static Ventas getVentas(string codigo)
        {
            Ventas v = new Ventas();
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select * from ventas where codigo = {0}", codigo), con);
                SqlDataReader re = comand.ExecuteReader();
                if (re.HasRows)
                {
                    while (re.Read())
                    {
                        v.Cant_Comprada = re["cantcomprada"].ToString();
                        v.Carro_Comprado = re["carrocomprado"].ToString();
                        v.codigo = re["codigo"].ToString();
                        v.Nombre_Cliente = re["nombrecliente"].ToString();
                        v.Precio_Und = re["preciound"].ToString();
                        v.Total_pagar = re["totalpagar"].ToString();
                    }
                }
                else
                {
                    v = null;
                }
                con.Close();
            }
            return v;
        }
        public static string getCodigoauto(string codigo)
        {
            string r = null;
            using (SqlConnection con = ConnectionDB.conectar())
            {
                SqlCommand comand = new SqlCommand(string.Format("select codigoauto from ventas where codigo = {0}", codigo), con);
                r = comand.ExecuteScalar().ToString();
                con.Close();
            }
            return r;
        }
    }
}
