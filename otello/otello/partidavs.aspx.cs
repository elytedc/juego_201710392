using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections;

namespace otello

{
    public partial class partidavs : System.Web.UI.Page

    {
        public static string[,] ma = new string[9, 9];
        public static string colorito = "";
        public static string fila = "";
        public static string columna = "";
        public static string estado = "falso";
        public static string colorturno = "";
        public static int con = 1;
        public static Boolean a = true;
        public static Boolean b = true;
        public static Boolean c = true;
        public static Boolean d = true;


        public object FlatStyle { get; private set; }
        public object DialogResult { get; private set; }

        protected void Page_Load(object sender, EventArgs e)

        {
            if (IsPostBack)
            {
                System.Web.HttpPostedFile file = Request.Files["fUpload"];
                if (file != null && file.ContentLength > 0)
                {
                    a10();
                }
            }
        }

        public void mostrar()
        {
            for (int x = 1; x < 9; x++)
            {
                for (int y = 1; y < 9; y++)
                {
                    if (ma[x, y] == "B")

                    {
                        if (ma[x, y] == ma[1, 1]) { a01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 2]) { a02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 3]) { a03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 4]) { a04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 5]) { a05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 6]) { a06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 7]) { a07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[1, 8]) { a08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[2, 1]) { b01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 2]) { b02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 3]) { b03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 4]) { b04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 5]) { b05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 6]) { b06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 7]) { b07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[2, 8]) { b08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[3, 1]) { c1.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 2]) { c02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 3]) { c03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 4]) { c04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 5]) { c05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 6]) { c06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 7]) { c07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[3, 8]) { c08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[4, 1]) { d01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 2]) { d02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 3]) { d03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 4]) { d04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 5]) { d05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 6]) { d06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 7]) { d07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[4, 8]) { d08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[5, 1]) { e01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 2]) { e02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 3]) { e03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 4]) { e04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 5]) { e05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 6]) { e06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 7]) { e07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[5, 8]) { e08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[6, 1]) { f01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 2]) { f02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 3]) { f03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 4]) { f04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 5]) { f05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 6]) { f06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 7]) { f07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[6, 8]) { f08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[7, 1]) { g01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 2]) { g02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 3]) { g03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 4]) { g04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 5]) { g05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 6]) { g06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 7]) { g07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[7, 8]) { g08.BackColor = System.Drawing.Color.White; }

                        if (ma[x, y] == ma[8, 1]) { h01.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 2]) { h02.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 3]) { h03.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 4]) { h04.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 5]) { h05.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 6]) { h06.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 7]) { h07.BackColor = System.Drawing.Color.White; }
                        if (ma[x, y] == ma[8, 8]) { h08.BackColor = System.Drawing.Color.White; }


                    }

                    else if (ma[x, y] == "N")
                    {
                        if (ma[x, y] == ma[1, 1]) { a01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 2]) { a02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 3]) { a03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 4]) { a04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 5]) { a05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 6]) { a06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 7]) { a07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[1, 8]) { a08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[2, 1]) { b01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 2]) { b02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 3]) { b03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 4]) { b04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 5]) { b05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 6]) { b06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 7]) { b07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[2, 8]) { b08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[3, 1]) { c1.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 2]) { c02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 3]) { c03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 4]) { c04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 5]) { c05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 6]) { c06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 7]) { c07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[3, 8]) { c08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[4, 1]) { d01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 2]) { d02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 3]) { d03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 4]) { d04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 5]) { d05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 6]) { d06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 7]) { d07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[4, 8]) { d08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[5, 1]) { e01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 2]) { e02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 3]) { e03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 4]) { e04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 5]) { e05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 6]) { e06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 7]) { e07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[5, 8]) { e08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[6, 1]) { f01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 2]) { f02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 3]) { f03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 4]) { f04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 5]) { f05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 6]) { f06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 7]) { f07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[6, 8]) { f08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[7, 1]) { g01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 2]) { g02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 3]) { g03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 4]) { g04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 5]) { g05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 6]) { g06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 7]) { g07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[7, 8]) { g08.BackColor = System.Drawing.Color.Black; }

                        if (ma[x, y] == ma[8, 1]) { h01.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 2]) { h02.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 3]) { h03.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 4]) { h04.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 5]) { h05.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 6]) { h06.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 7]) { h07.BackColor = System.Drawing.Color.Black; }
                        if (ma[x, y] == ma[8, 8]) { h08.BackColor = System.Drawing.Color.Black; }

                    }

                    else {
                        if (ma[x, y] == ma[1, 1]) { a01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 2]) { a02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 3]) { a03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 4]) { a04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 5]) { a05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 6]) { a06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 7]) { a07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[1, 8]) { a08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[2, 1]) { b01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 2]) { b02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 3]) { b03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 4]) { b04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 5]) { b05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 6]) { b06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 7]) { b07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[2, 8]) { b08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[3, 1]) { c1.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 2]) { c02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 3]) { c03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 4]) { c04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 5]) { c05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 6]) { c06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 7]) { c07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[3, 8]) { c08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[4, 1]) { d01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 2]) { d02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 3]) { d03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 4]) { d04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 5]) { d05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 6]) { d06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 7]) { d07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[4, 8]) { d08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[5, 1]) { e01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 2]) { e02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 3]) { e03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 4]) { e04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 5]) { e05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 6]) { e06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 7]) { e07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[5, 8]) { e08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[6, 1]) { f01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 2]) { f02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 3]) { f03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 4]) { f04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 5]) { f05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 6]) { f06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 7]) { f07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[6, 8]) { f08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[7, 1]) { g01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 2]) { g02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 3]) { g03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 4]) { g04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 5]) { g05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 6]) { g06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 7]) { g07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[7, 8]) { g08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        if (ma[x, y] == ma[8, 1]) { h01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 2]) { h02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 3]) { h03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 4]) { h04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 5]) { h05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 6]) { h06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 7]) { h07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }
                        if (ma[x, y] == ma[8, 8]) { h08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C"); }

                        
                    }


                }
            }



                    }


        public void recorrer(int fila, int columna, string color)
        {

            if (colorturno == "blanco")
            {
                
                if (ma[fila, columna] == "PA") {
                    ma[fila, columna] = color;

                    for (int z = fila; z < 9; z++)
                    {
                        
                        if (ma[z, columna] == "B")
                        {
                            z = 9;
                        }
                        else { ma[z, columna] = "B"; }
                        
                    } }

                //abajo suma de fila
                
                if (ma[fila, columna] == "PE")
                {
                    ma[fila, columna] = color;
                    for (int z = fila; z > 0; z--)
                    {
                        
                        if (ma[z, columna] == "B")
                        {
                            z = 0;
                        }
                        else { ma[z, columna] = "B"; }
                        
                    }
                }



                //derecha suma de fila

                if (ma[fila, columna] == "PI")
                {
                    ma[fila, columna] = color;
                    for (int z = columna; z < 9; z++)
                    {
                        
                        if (ma[fila, z] == "B")
                        {
                            z = 9;
                        }
                        else { ma[fila, z] = "B"; }
                        
                    }
                }

                //izquierda suma de fil
                if (ma[fila, columna] == "PO")
                {
                    ma[fila, columna] = color;
                    for (int z = columna; z > 0; z--)
                    {
                        
                        if (ma[fila, z] == "B")
                        {
                            z = 0;
                        }
                        else { ma[fila, z] = "B"; }
                        
                    }
                }



            }

            if (colorturno == "negro")
            {
                if (ma[fila, columna] == "PA")
                {
                    ma[fila, columna] = color;
                    for (int z = fila; z < 9; z++)
                    {

                        if (ma[z, columna] == "N")
                        {
                            z = 9;
                        }
                        else { ma[z, columna] = "N"; }
                        
                    }
                }

                //abajo suma de fila

                if (ma[fila, columna] == "PE")
                {
                    ma[fila, columna] = color;
                    for (int z = fila; z > 0; z--)
                    {

                        if (ma[z, columna] == "N")
                        {
                            z = 0;
                        }
                        else { ma[z, columna] = "N"; }
                        
                    }
                }



                //derecha suma de fila

                if (ma[fila, columna] == "PI")
                {
                    ma[fila, columna] = color;
                    for (int z = columna; z < 9; z++)
                    {

                        if (ma[fila, z] == "N")
                        {
                            z = 9;
                        }
                        else { ma[fila, z] = "N"; }
                        
                    }
                }

                //izquierda suma de fil
                if (ma[fila, columna] == "PO")
                {
                    ma[fila, columna] = color;
                    for (int z = columna; z > 0; z--)
                    {

                        if (ma[fila, z] == "N")
                        {
                            z = 0;
                        }
                        else { ma[fila, z] = "N"; }
                        
                    }
                }




            }

            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[x, y] == "PA" || ma[x, y] == "PE" || ma[x, y] == "PI" || ma[x, y] == "PO")
                    {
                        ma[x, y] = " ";
                    }
                    else { }
                }
            }

            a = false;
            b = false;
            c = false;
            d = false;




        }


        public void posibles()
        {
                for (int x = 1; x < 9; x++)
                {
                    for (int y = 1; y < 9; y++)
                    {
                    if (ma[x, y] == "PA" || ma[x, y] == "PE" || ma[x, y] == "PI" || ma[x, y] == "PO")

                    {
                        if (ma[x, y] == ma[1, 1]) { a01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 2]) { a02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 3]) { a03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 4]) { a04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 5]) { a05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 6]) { a06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 7]) { a07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[1, 8]) { a08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[2, 1]) { b01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 2]) { b02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 3]) { b03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 4]) { b04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 5]) { b05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 6]) { b06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 7]) { b07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[2, 8]) { b08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[3, 1]) { c1.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 2]) { c02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 3]) { c03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 4]) { c04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 5]) { c05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 6]) { c06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 7]) { c07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[3, 8]) { c08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[4, 1]) { d01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 2]) { d02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 3]) { d03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 4]) { d04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 5]) { d05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 6]) { d06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 7]) { d07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[4, 8]) { d08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[5, 1]) { e01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 2]) { e02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 3]) { e03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 4]) { e04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 5]) { e05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 6]) { e06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 7]) { e07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[5, 8]) { e08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[6, 1]) { f01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 2]) { f02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 3]) { f03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 4]) { f04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 5]) { f05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 6]) { f06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 7]) { f07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[6, 8]) { f08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[7, 1]) { g01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 2]) { g02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 3]) { g03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 4]) { g04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 5]) { g05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 6]) { g06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 7]) { g07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[7, 8]) { g08.BackColor = System.Drawing.Color.Red; }

                        if (ma[x, y] == ma[8, 1]) { h01.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 2]) { h02.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 3]) { h03.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 4]) { h04.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 5]) { h05.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 6]) { h06.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 7]) { h07.BackColor = System.Drawing.Color.Red; }
                        if (ma[x, y] == ma[8, 8]) { h08.BackColor = System.Drawing.Color.Red; }

                    }
                    else { }    
                    


                }
                }

            
        }


        public void tabla(int fila, int columna,string color)
        {
            ma[fila, columna] = color;


            if (colorturno=="blanco") {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y]=="B")

                        {
                            //arriba suma de fila
                            if (ma[x + 1, y]=="N") { ma[x + 2, y] = "PA"; }
                            //abajo suma de fila
                            if (ma[x - 1, y]=="N") { ma[x - 2, y] = "PE"; }
                            //derecha suma de fila
                            if (ma[x, y + 1]=="N") { ma[x, y + 2] = "PI"; }
                            //izquierda suma de fila
                            if (ma[x, y - 1]=="N") { ma[x, y - 2] = "PO"; }

                        }
                        else { }
                    }
                }
            }

            if (colorturno == "negro")
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "N")

                        {
                            //arriba suma de fila
                            if (ma[x + 1, y] == "B") { ma[x + 2, y] = "PA"; }
                            //abajo suma de fila
                            if (ma[x - 1, y] == "B") { ma[x - 2, y] = "PE"; }
                            //derecha suma de fila
                            if (ma[x, y + 1] == "B") { ma[x, y + 2] = "PI"; }
                            //izquierda suma de fila
                            if (ma[x, y - 1] == "B") { ma[x, y - 2] = "PO"; }

                        }
                        else { }
                    }
                }
            }
        }


        public void tabla1()
        {
            if (colorturno == "blanco")
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "B")

                        {
                            //arriba suma de fila
                            if (ma[x + 1, y] == "N") {
                                for (int z = x; z < 9; z++)
                                {
                                    if (ma[z, y] == " "&& ma[z-1, y] == "N") { ma[z, y] = "PA"; z = 9;
                                        a = true;
                                    }
                                }
                            }

                            //abajo suma de fila
                            if (ma[x - 1, y] == "N") {
                                for (int z = x; z>0; z--)
                                {
                                    if (ma[z, y] == " " && ma[z +1, y] == "N") { ma[z, y] = "PE"; z = 0; b = true; }
                                }
                            }


                            //derecha suma de fila
                            if (ma[x, y + 1] == "N") {
                                for (int z = y; z < 9; z++)
                                {
                                    if (ma[x, z] == " " && ma[x, z-1] == "N") { ma[x, z] = "PI"; z = 9; c = true; }
                                }
                            }
                            //izquierda suma de fila
                            if (ma[x, y - 1] == "N") {
                                for (int z = y;z>0; z--)
                                {
                                    if (ma[x, z] == " " && ma[x, z + 1] == "N") { ma[x, z] = "PO"; z = 0; d = true; }
                                }
                            }

                        }
                        
                    }
                }
            }

            if (colorturno == "negro")
            {

                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "N")

                        {
                            //arriba suma de fila
                            if (ma[x + 1, y] == "B")
                            {
                                for (int z = x; z < 9; z++)
                                {
                                    if (ma[z, y] == " " && ma[z - 1, y] == "B")
                                    {
                                        ma[z, y] = "PA"; z = 9;
                                        a = true;
                                    }
                                }
                            }

                            //abajo suma de fila
                            if (ma[x - 1, y] == "B")
                            {
                                for (int z = x; z > 0; z--)
                                {
                                    if (ma[z, y] == " " && ma[z + 1, y] == "B") { ma[z, y] = "PE"; z = 0; b = true; }
                                }
                            }


                            //derecha suma de fila
                            if (ma[x, y + 1] == "B")
                            {
                                for (int z = y; z < 9; z++)
                                {
                                    if (ma[x, z] == " " && ma[x, z - 1] == "B") { ma[x, z] = "PI"; z = 9; c = true; }
                                }
                            }
                            //izquierda suma de fila
                            if (ma[x, y - 1] == "B")
                            {
                                for (int z = y; z > 0; z--)
                                {
                                    if (ma[x, z] == " " && ma[x, z + 1] == "B") { ma[x, z] = "PO"; z = 0; d = true; }
                                }
                            }

                        }

                    }
                }

            }
        }


        public void botones(string fila, string columna, string color)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void a01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a01.BackColor = System.Drawing.Color.White;
                recorrer(1, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a01.BackColor = System.Drawing.Color.Black;
                recorrer(1, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }



        protected void b01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b01.BackColor = System.Drawing.Color.White;
                recorrer(2, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b01.BackColor = System.Drawing.Color.Black;
                recorrer(2, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        public void a10()
        {
            string c = fUpload.FileName;
            string cadena = @"C:\Users\john\Desktop\ipc2\juego\juego_201710392\otello\otello\xml\" + c;
            XmlReader lectura = XmlReader.Create(cadena);


            while (lectura.Read())
            {
                if (lectura.IsStartElement())
                {
                    if (estado == "falso")
                    {
                        switch (lectura.Name.ToString())
                        {
                            case "color": colorito = lectura.ReadString(); break;
                            case "fila": fila = lectura.ReadString(); break;
                            case "columna": columna = lectura.ReadString(); break;
                            case "siguienteTiro":
                                estado = "verdadero";
                                break;
                        }
                    }
                    else
                    {

                        switch (lectura.Name.ToString())
                        {
                            case "color":
                                colorturno = lectura.ReadString();
                                estado = "falso";
                                break;

                        }


                    }

                }

                if ((colorito == "blanco"))
                {
                    if ((fila == "1") && (columna == "A")) { a01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "A")) { a02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "A")) { a03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "A")) { a04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "A")) { a05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "A")) { a06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "A")) { a07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "A")) { a08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "B")) { b01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "B")) { b02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "B")) { b03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "B")) { b04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "B")) { b05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "B")) { b06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "B")) { b07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "B")) { b08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "C")) { c1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "C")) { c02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "C")) { c03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "C")) { c04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "C")) { c05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "C")) { c06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "C")) { c07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "C")) { c08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "D")) { d01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "D")) { d02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "D")) { d03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "D")) { d04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "D")) { d05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "D")) { d06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "D")) { d07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "D")) { d08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "E")) { e01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "E")) { e02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "E")) { e03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "E")) { e04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "E")) { e05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "E")) { e06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "E")) { e07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "E")) { e08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "F")) { f01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "F")) { f02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "F")) { f03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "F")) { f04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "F")) { f05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "F")) { f06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "F")) { f07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "F")) { f08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "G")) { g01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "G")) { g02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "G")) { g03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "G")) { g04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "G")) { g05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "G")) { g06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "G")) { g07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "G")) { g08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "H")) { h01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "H")) { h02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "H")) { h03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "H")) { h04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "H")) { h05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "H")) { h06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "H")) { h07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "H")) { h08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }



                }
                else
                {
                    if ((fila == "1") && (columna == "A")) { a01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "A")) { a02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "A")) { a03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "A")) { a04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "A")) { a05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "A")) { a06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "A")) { a07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "A")) { a08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "B")) { b01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "B")) { b02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "B")) { b03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "B")) { b04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "B")) { b05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "B")) { b06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "B")) { b07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "B")) { b08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "C")) { c1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "C")) { c02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "C")) { c03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "C")) { c04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "C")) { c05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "C")) { c06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "C")) { c07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "C")) { c08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "D")) { d01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "D")) { d02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "D")) { d03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "D")) { d04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "D")) { d05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "D")) { d06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "D")) { d07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "D")) { d08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "E")) { e01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "E")) { e02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "E")) { e03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "E")) { e04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "E")) { e05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "E")) { e06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "E")) { e07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "E")) { e08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "F")) { f01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "F")) { f02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "F")) { f03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "F")) { f04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "F")) { f05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "F")) { f06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "F")) { f07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "F")) { f08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "G")) { g01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "G")) { g02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "G")) { g03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "G")) { g04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "G")) { g05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "G")) { g06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "G")) { g07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "G")) { g08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "H")) { h01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "H")) { h02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "H")) { h03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "H")) { h04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "H")) { h05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "H")) { h06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "H")) { h07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "H")) { h08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                }


            }




        }


        protected void a02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a02.BackColor = System.Drawing.Color.White;
                recorrer(1, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a02.BackColor = System.Drawing.Color.Black;
                recorrer(1, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a03.BackColor = System.Drawing.Color.White;
                recorrer(1, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a03.BackColor = System.Drawing.Color.Black;
                recorrer(1, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a04.BackColor = System.Drawing.Color.White;
                recorrer(1, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a04.BackColor = System.Drawing.Color.Black;
                recorrer(1, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a05.BackColor = System.Drawing.Color.White;
                recorrer(1, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a05.BackColor = System.Drawing.Color.Black;
                recorrer(1, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a06.BackColor = System.Drawing.Color.White;
                recorrer(1, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a06.BackColor = System.Drawing.Color.Black;
                recorrer(1, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a07.BackColor = System.Drawing.Color.White;
                recorrer(1, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a07.BackColor = System.Drawing.Color.Black;
                recorrer(1, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a08.BackColor = System.Drawing.Color.White;
                recorrer(1, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { a08.BackColor = System.Drawing.Color.Black;
                recorrer(1, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b02.BackColor = System.Drawing.Color.White;
                recorrer(2, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b02.BackColor = System.Drawing.Color.Black;
                recorrer(2, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b03.BackColor = System.Drawing.Color.White;
                recorrer(2, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b03.BackColor = System.Drawing.Color.Black;
                recorrer(2, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b04.BackColor = System.Drawing.Color.White;
                recorrer(2, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b04.BackColor = System.Drawing.Color.Black;
                recorrer(2, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b05.BackColor = System.Drawing.Color.White;
                recorrer(2, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b05.BackColor = System.Drawing.Color.Black;
                recorrer(2, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b06.BackColor = System.Drawing.Color.White;
                recorrer(2, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b06.BackColor = System.Drawing.Color.Black;
                recorrer(2, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b07.BackColor = System.Drawing.Color.White;
                recorrer(2, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b07.BackColor = System.Drawing.Color.Black;
                recorrer(2, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b08.BackColor = System.Drawing.Color.White;
                recorrer(2, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { b08.BackColor = System.Drawing.Color.Black;
                recorrer(2, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c1.BackColor = System.Drawing.Color.White;
                recorrer(3, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c1.BackColor = System.Drawing.Color.Black;
                recorrer(3, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c02.BackColor = System.Drawing.Color.White;
                recorrer(3, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c02.BackColor = System.Drawing.Color.Black;
                recorrer(3, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c03.BackColor = System.Drawing.Color.White;
                recorrer(3, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c03.BackColor = System.Drawing.Color.Black;
                recorrer(3, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c04.BackColor = System.Drawing.Color.White;
                recorrer(3, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c04.BackColor = System.Drawing.Color.Black;
                recorrer(3, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();

            }
        }

        protected void c05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c05.BackColor = System.Drawing.Color.White;
                recorrer(3, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c05.BackColor = System.Drawing.Color.Black;
                recorrer(3, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c06.BackColor = System.Drawing.Color.White;
                recorrer(3, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c06.BackColor = System.Drawing.Color.Black;
                recorrer(3, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c07.BackColor = System.Drawing.Color.White;
                recorrer(3, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c07.BackColor = System.Drawing.Color.Black;
                recorrer(3, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c08.BackColor = System.Drawing.Color.White;
                recorrer(3, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { c08.BackColor = System.Drawing.Color.Black;
                recorrer(3, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d01.BackColor = System.Drawing.Color.White;
                recorrer(4, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d01.BackColor = System.Drawing.Color.Black;
                recorrer(4, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d02.BackColor = System.Drawing.Color.White;
                recorrer(4, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d02.BackColor = System.Drawing.Color.Black;
                recorrer(4, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d03.BackColor = System.Drawing.Color.White;

                recorrer(4, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();

            }
            else { d03.BackColor = System.Drawing.Color.Black;
                recorrer(4, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d04_Click(object sender, EventArgs e)
        {
            
 

            if (colorturno == "blanco") { d04.BackColor = System.Drawing.Color.White;
                recorrer(4, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d04.BackColor = System.Drawing.Color.Black;
                recorrer(4, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d05.BackColor = System.Drawing.Color.White;
                recorrer(4, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d05.BackColor = System.Drawing.Color.Black;
                recorrer(4, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d06.BackColor = System.Drawing.Color.White;
                recorrer(4, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d06.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
                recorrer(4, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();

            }
            
        }

        protected void d07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d07.BackColor = System.Drawing.Color.White;
                recorrer(4, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d07.BackColor = System.Drawing.Color.Black;
                recorrer(4, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d08.BackColor = System.Drawing.Color.White;
                recorrer(4, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { d08.BackColor = System.Drawing.Color.Black;
                recorrer(4, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e01.BackColor = System.Drawing.Color.White;
                recorrer(5, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e01.BackColor = System.Drawing.Color.Black;
                recorrer(5, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }

        }

        protected void e02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e02.BackColor = System.Drawing.Color.White;
                recorrer(5, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e02.BackColor = System.Drawing.Color.Black;
                recorrer(5, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e03.BackColor = System.Drawing.Color.White;
                recorrer(5, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e03.BackColor = System.Drawing.Color.Black;
                recorrer(5, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e04.BackColor = System.Drawing.Color.White;
                recorrer(5, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e04.BackColor = System.Drawing.Color.Black;
                recorrer(5, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        

        protected void e06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e06.BackColor = System.Drawing.Color.White;
                recorrer(5, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e06.BackColor = System.Drawing.Color.Black;
                recorrer(5, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e07.BackColor = System.Drawing.Color.White;
                recorrer(5, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e07.BackColor = System.Drawing.Color.Black;
                recorrer(5, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e08.BackColor = System.Drawing.Color.White;
                recorrer(5, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e08.BackColor = System.Drawing.Color.Black;
                recorrer(5, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f01.BackColor = System.Drawing.Color.White;
                recorrer(6, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f01.BackColor = System.Drawing.Color.Black;
                recorrer(6, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f02.BackColor = System.Drawing.Color.White;
                recorrer(6, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f02.BackColor = System.Drawing.Color.Black;
                recorrer(6, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f03.BackColor = System.Drawing.Color.White;
                recorrer(6, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f03.BackColor = System.Drawing.Color.Black;
                recorrer(6, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f04.BackColor = System.Drawing.Color.White;
                recorrer(6, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();

            }
            else { f04.BackColor = System.Drawing.Color.Black;
                recorrer(6, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f05.BackColor = System.Drawing.Color.White;
                recorrer(6, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f05.BackColor = System.Drawing.Color.Black;
                recorrer(6, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f06.BackColor = System.Drawing.Color.White;
                recorrer(6, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f06.BackColor = System.Drawing.Color.Black;
                recorrer(6, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f07.BackColor = System.Drawing.Color.White;
                recorrer(6, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f07.BackColor = System.Drawing.Color.Black;
                recorrer(6, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { f08.BackColor = System.Drawing.Color.White;
                recorrer(6, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { f08.BackColor = System.Drawing.Color.Black;
                recorrer(6, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g01.BackColor = System.Drawing.Color.White;
                recorrer(7, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();

            }
            else { g01.BackColor = System.Drawing.Color.Black;
                recorrer(7, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g02.BackColor = System.Drawing.Color.White;
                recorrer(7, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g02.BackColor = System.Drawing.Color.Black;
                recorrer(7, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g03.BackColor = System.Drawing.Color.White;
                recorrer(7, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g03.BackColor = System.Drawing.Color.Black;
                recorrer(7, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g04.BackColor = System.Drawing.Color.White;
                recorrer(7, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g04.BackColor = System.Drawing.Color.Black;
                recorrer(7, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g05.BackColor = System.Drawing.Color.White;
                recorrer(7, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g05.BackColor = System.Drawing.Color.Black;
                recorrer(7, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g06.BackColor = System.Drawing.Color.White;
                recorrer(7, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g06.BackColor = System.Drawing.Color.Black;
                recorrer(7, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g07.BackColor = System.Drawing.Color.White;
                recorrer(7, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g07.BackColor = System.Drawing.Color.Black;
                recorrer(7, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { g08.BackColor = System.Drawing.Color.White;
                recorrer(7, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { g08.BackColor = System.Drawing.Color.Black;
                recorrer(7, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h01.BackColor = System.Drawing.Color.White;
                recorrer(8, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h01.BackColor = System.Drawing.Color.Black; 
                recorrer(8, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h02.BackColor = System.Drawing.Color.White;
                recorrer(8, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h02.BackColor = System.Drawing.Color.Black;
                recorrer(8, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h03.BackColor = System.Drawing.Color.White;
                recorrer(8, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h03.BackColor = System.Drawing.Color.Black;
                recorrer(8, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h04.BackColor = System.Drawing.Color.White;
                recorrer(8, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h04.BackColor = System.Drawing.Color.Black;
                recorrer(8, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h05.BackColor = System.Drawing.Color.White;
                recorrer(8, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h05.BackColor = System.Drawing.Color.Black;
                recorrer(8, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h06.BackColor = System.Drawing.Color.White;
                recorrer(8, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h06.BackColor = System.Drawing.Color.Black;
                recorrer(8, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h07.BackColor = System.Drawing.Color.White;
                recorrer(8, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h07.BackColor = System.Drawing.Color.Black;
                recorrer(8, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { h08.BackColor = System.Drawing.Color.White;
                recorrer(8, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { h08.BackColor = System.Drawing.Color.Black;
                recorrer(8, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }



        public void guardarxml()
        {
            XDocument document = new XDocument(new XDeclaration("1.0", "utf-8", null));
            XElement cabeza = new XElement("tablero");
            document.Add(cabeza);
            if (a01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (a02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (a03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (a04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (a05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (a06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (a07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (a08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (b01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (b02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (b03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (b04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (b05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (b06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (b07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (b08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (c1.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (c02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (c03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (c04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (c05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (c06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (c07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (c08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (d01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (d02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (d03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (d04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (d05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (d06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (d07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (d08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (e01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (e02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (e03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (e04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (e05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (e06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (e07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (e08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (f01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (f02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (f03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (f04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (f05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (f06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (f07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (f08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (g01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (g02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (g03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (g04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (g05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (g06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (g07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (g08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (h01.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (h02.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (h03.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (h04.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (h05.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (h06.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (h07.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (h08.BackColor == System.Drawing.Color.White)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "blanco")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (a01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (a02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (a03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (a04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (a05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (a06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (a07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (a08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "A"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (b01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (b02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (b03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (b04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (b05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (b06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (b07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (b08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "B"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (c1.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (c02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (c03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (c04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (c05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (c06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (c07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (c08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "C"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (d01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (d02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (d03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (d04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (d05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (d06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (d07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (d08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "D"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (e01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (e02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (e03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (e04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (e05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (e06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (e07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (e08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "E"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (f01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (f02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (f03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (f04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (f05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (f06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (f07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (f08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "F"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }

            if (g01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (g02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (g03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (g04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (g05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (g06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (g07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (g08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "G"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            if (h01.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "1")); cabeza.Add(ficha);
            }
            if (h02.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "2")); cabeza.Add(ficha);
            }
            if (h03.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "3")); cabeza.Add(ficha);
            }
            if (h04.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "4")); cabeza.Add(ficha);
            }
            if (h05.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "5")); cabeza.Add(ficha);
            }
            if (h06.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "6")); cabeza.Add(ficha);
            }
            if (h07.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "7")); cabeza.Add(ficha);
            }
            if (h08.BackColor == System.Drawing.Color.Black)
            {
                XElement ficha = new XElement("ficha"); ficha.Add(new XElement("color", "negro")); ficha.Add(new XElement("columna", "H"));
                ficha.Add(new XElement("fila", "8")); cabeza.Add(ficha);
            }


            XElement color = new XElement("siguienteTiro");
            color.Add(new XElement("color", colorturno)); cabeza.Add(color);
            document.Save(@"C:\Users\john\Desktop\ipc2\juego\juego_201710392\otello\otello\xml\partida" + con + ".xml");
            con++;






        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            guardarxml();
        }

        protected void B_Click(object sender, EventArgs e)
        {
            a01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            a08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            b01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            b08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            c1.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            c08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            d01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            d08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            e01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            e08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            f01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            f08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            g01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            g08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");

            h01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
            h08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");


        }

        protected void e05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { e05.BackColor = System.Drawing.Color.White; 
                recorrer(5, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else { e05.BackColor = System.Drawing.Color.Black;
                recorrer(5, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    ma[z, y] = " ";
                }
            }

            colorturno = "blanco";
            ma[4, 4] = "B";
            ma[5, 4] = "N";
            ma[4, 5] = "N";
            tabla(5, 5, "B");
            posibles();

        }
    }
}