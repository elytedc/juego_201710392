using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace tomos
{
   public  class sincronizar
    {
        public bool insertar( string nombre, string apellido, string usuario, string contraseña, string fecha1, string pais1,string correo)
        {
            conexion cn = new conexion();
            try
            {
                string sql = "Insert into base_usuarios values ('" + nombre+ "','"+apellido+ "','"+usuario+ "','"+contraseña+ "','"+fecha1+ "','"+pais1+ "','" + correo + "')";
                SqlCommand cmd = new SqlCommand(sql, cn.getTomos());
                int n = cmd.ExecuteNonQuery();
                return n > 0;


            }
            
            catch (Exception)
            {
                return false;

            }
        }


        public bool buscar(string usuario, string contraseña)
        {
            conexion cn = new conexion();
            try
            {
                string sql = "SELECT * FROM base_usuarios WHERE usuario = '"+usuario+"' AND contraseña = '"+contraseña+"'";
                SqlCommand cmd = new SqlCommand(sql, cn.getTomos());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt.Rows.Count == 1;
               


            }

            catch (Exception)
            {
                return false;
            }
        }


    }
}
