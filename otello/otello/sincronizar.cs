using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace otello
{
    public class sincronizar
    {

        public SqlConnection getTomos()
        {

            string ruta = "Data Source=DESKTOP-VLR9CVA;Initial Catalog=usuarios_otello;Integrated Security=True";
            SqlConnection bas = new SqlConnection(ruta);
            bas.Open();
            return bas;}


        public bool insertar(string nombre, string apellido, string usuario, string contraseña, string fecha1, string pais1, string correo)
        {
            sincronizar bas = new sincronizar();
            try
            {
                string sql = "Insert into base_usuarios values ('" + nombre + "','" + apellido + "','" + usuario + "','" + contraseña + "','" + fecha1 + "','" + pais1 + "','" + correo + "')";
                SqlCommand lectura = new SqlCommand(sql, bas.getTomos());
                int estado = lectura.ExecuteNonQuery();
                return estado > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool buscar(string usuario, string contraseña)
        {
            sincronizar bas = new sincronizar();
            try
            {
                string sql = "SELECT * FROM base_usuarios WHERE usuario = '" + usuario + "' AND contraseña = '" + contraseña + "'";
                SqlCommand lectura = new SqlCommand(sql, bas.getTomos());
                SqlDataAdapter sda = new SqlDataAdapter(lectura);
                DataTable tabla = new DataTable();
                sda.Fill(tabla);
                return tabla.Rows.Count >0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool validar(string usuario)
        {
            sincronizar bas = new sincronizar();
            try
            {
                string sql = "SELECT * FROM base_usuarios WHERE usuario = '" + usuario + "'";
                SqlCommand lectura = new SqlCommand(sql, bas.getTomos());
                SqlDataAdapter iten = new SqlDataAdapter(lectura);
                DataTable tabla = new DataTable();
                iten.Fill(tabla);
                return tabla.Rows.Count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }



}




