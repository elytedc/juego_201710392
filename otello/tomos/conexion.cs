﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace tomos
{
    public class conexion
    {
        public SqlConnection getTomos()
        {
            try{
                string cadena = "Data Source=DESKTOP-VLR9CVA;Initial Catalog=usuarios_otello;Integrated Security=True";
                SqlConnection cn = new SqlConnection(cadena);
                cn.Open();
                return cn;
            }
            catch(Exception)
            {
                return null;
            }

        }

    }
}
