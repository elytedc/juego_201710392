using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace otello
{
    public partial class RETO_INVERSO : System.Web.UI.Page
    {
        public static string[,] ma = new string[10, 10];
        public static string colorito = "";
        public static string fila = "";
        public static string columna = "";
        public static string estado = "falso";
        public static string colorturno = "";
        public static string colorlogeado = "";
        public static int con = 1;
        public static string yy = "x";
        public static int b = 0;
        public static int n = 0;
        public static int tiempoj1 = 0;
        public static int tiempoj2 = 0;
        public static int tiempoj1m = 0;
        public static int tiempoj2m = 0;


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
                    mostrar();
                    tabla1();
                    posibles();
                    Timer1.Enabled = true;

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

                    else
                    {
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


                if (ma[fila, columna] == "PO")
                {


                    for (int z = columna; z < 9; z++)
                    {

                        if (ma[fila, z] == "B")
                        {
                            z = 9;
                        }
                        else { ma[fila, z] = "B"; }


                    }
                    ma[fila, columna] = color;
                }

                //abajo suma de fila

                if (ma[fila, columna] == "PI")
                {

                    for (int z = columna; z > 0; z--)
                    {

                        if (ma[fila, z] == "B")
                        {
                            z = 0;
                        }
                        else { ma[fila, z] = "B"; }

                    }
                    ma[fila, columna] = color;
                }



                //derecha suma de fila

                if (ma[fila, columna] == "PE")
                {

                    for (int z = fila; z < 9; z++)
                    {

                        if (ma[z, columna] == "B")
                        {
                            z = 9; //ma[5, 4] = "B";
                        }
                        else { ma[z, columna] = "B"; }

                    }
                    ma[fila, columna] = color;
                }

                //izquierda suma de fil
                if (ma[fila, columna] == "PA")
                {

                    for (int z = fila; z > 0; z--)
                    {

                        if (ma[z, columna] == "B")
                        {
                            z = 0;
                        }
                        else { ma[z, columna] = "B"; }

                    }
                    ma[fila, columna] = color;
                }

                if (ma[fila, columna] == "MA")
                {
                    int v = columna;

                    for (int z = fila; z < 9; z++)
                    {

                        if (ma[z, v] == "B")
                        {
                            z = 9; //ma[5, 4] = "B";
                        }
                        else { ma[z, v] = "B"; }
                        v--;
                        if (v < 1) { break; }
                    }
                    ma[fila, columna] = color;
                }

                //izquierda suma de fil
                if (ma[fila, columna] == "ME")
                {
                    int v = columna;
                    for (int z = fila; z > 0; z--)
                    {

                        if (ma[z, v] == "B")
                        {
                            z = 0;
                        }
                        else { ma[z, v] = "B"; }
                        v++;
                        if (v > 8) { break; }
                    }
                    ma[fila, columna] = color;
                }



            }

            if (colorturno == "negro")
            {
                if (ma[fila, columna] == "PO")
                {


                    for (int z = columna; z < 9; z++)
                    {

                        if (ma[fila, z] == "N")
                        {
                            z = 9;
                        }
                        else { ma[fila, z] = "N"; }


                    }
                    ma[fila, columna] = color;
                }

                //abajo suma de fila

                if (ma[fila, columna] == "PI")
                {

                    for (int z = columna; z > 0; z--)
                    {

                        if (ma[fila, z] == "N")
                        {
                            z = 0;
                        }
                        else { ma[fila, z] = "N"; }

                    }
                    ma[fila, columna] = color;
                }

                //derecha suma de fila
                //derecha suma de fila
                //derecha suma de fila

                if (ma[fila, columna] == "PE")
                {

                    for (int z = fila; z < 9; z++)
                    {

                        if (ma[z, columna] == "N")
                        {
                            z = 9; //ma[5, 4] = "B";
                        }
                        else { ma[z, columna] = "N"; }

                    }
                    ma[fila, columna] = color;
                }

                //izquierda suma de fil
                if (ma[fila, columna] == "PA")
                {

                    for (int z = fila; z > 0; z--)
                    {

                        if (ma[z, columna] == "N")
                        {
                            z = 0;
                        }
                        else { ma[z, columna] = "N"; }

                    }
                    ma[fila, columna] = color;
                }

                if (ma[fila, columna] == "MA")
                {
                    int v = columna;

                    for (int z = fila; z < 9; z++)
                    {

                        if (ma[z, v] == "N")
                        {
                            z = 9; //ma[5, 4] = "B";
                        }
                        else { ma[z, v] = "N"; }
                        v--;
                        if (v < 1) { break; }

                    }
                    ma[fila, columna] = color;
                }

                //izquierda suma de fil
                if (ma[fila, columna] == "ME")
                {
                    int v = columna;
                    for (int z = fila; z > 0; z--)
                    {

                        if (ma[z, v] == "N")
                        {
                            z = 0;
                        }
                        else { ma[z, v] = "N"; }
                        v++;
                        if (v > 8) { break; }
                    }
                    ma[fila, columna] = color;
                }

            }




            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[x, y] == "PA" || ma[x, y] == "PE" || ma[x, y] == "PI" || ma[x, y] == "PO" || ma[x, y] == "MA" || ma[x, y] == "ME" || ma[x, y] == "MI" || ma[x, y] == "MO")
                    {
                        ma[x, y] = " ";
                    }
                    else { }
                }
            }





        }

        public void resultado()
        {
            Timer1.Enabled = false;
            sincronizar p = new sincronizar();
            int b1 = 0;
            int b2 = 0;
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[z, y] == "B") { b1++; }
                    if (ma[z, y] == "N") { b2++; }
                }
            }
            if (b1 < b2)
            {
                Response.Write("<scrip>window.alert('ha Ganado BLANCO'"+b1 +"  "+b2+")</script>");
                if (colorlogeado == "negro") { p.insertar_partida("JUGADOR VS INVITADO", "PERDIO"); }
                else { p.insertar_partida("JUGADOR VS INVITADO", "GANO"); }


            }
            if (b1 == b2)
            {
                Response.Write("<scrip>window.alert('esto es empate'" + b1 + "  " + b2 + ")</script>");
                if (colorlogeado == "negro") { p.insertar_partida("JUGADOR VS INVITADO", "empate"); }
                else { p.insertar_partida("JUGADOR VS INVITADO", "empate"); }
            }
            if (b1 > b2)
            {
                Response.Write("<scrip>window.alert('ha Ganado NEGRO'" + b1 + "  " + b2 + ")</script>");
                if (colorlogeado == "negro") { p.insertar_partida("JUGADOR VS INVITADO", "GANO"); }
                else { p.insertar_partida("JUGADOR VS INVITADO", "PERDIO"); }
            }



        }


        public void posibles()
        {
            int a = 0;
            for (int x1 = 0; x1 < 9; x1++)
            {
                for (int y1 = 0; y1 < 9; y1++)
                {
                    if (ma[x1, y1] == " ")
                    {
                        yy = "a";
                    }

                }
            }

            if (yy == "x")
            {
                resultado();

            }

            else
            {

                for (int x = 1; x < 9; x++)
                {
                    for (int y = 1; y < 9; y++)
                    {
                        if (ma[x, y] == "PA" || ma[x, y] == "PE" || ma[x, y] == "PI" || ma[x, y] == "PO" || ma[x, y] == "MA" || ma[x, y] == "ME" || ma[x, y] == "MI" || ma[x, y] == "MO")

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
                            a++;
                        }


                    }

                }

                if (a == 0)
                {

                    if (colorturno == "negro")
                    { //colorturno = "blanco"; 
                    }
                    else
                    { //colorturno = "negro"; 
                    }
                    Label1.Text = "error no puede, precione cualquier boton para continiar " + colorturno;


                }
            }


            yy = "x";

        }

        public void tabla(int fila, int columna, string color)
        {
            ma[fila, columna] = color;

            Label1.Text = "LE TOCA A: " + colorturno;
            if (colorturno == "blanco")
            {
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "B")

                        {
                            //arriba suma de fila
                            if (ma[x + 1, y] == "N") { ma[x + 2, y] = "PA"; }
                            //abajo suma de fila
                            if (ma[x - 1, y] == "N") { ma[x - 2, y] = "PE"; }
                            //derecha suma de fila
                            if (ma[x, y + 1] == "N") { ma[x, y + 2] = "PI"; }
                            //izquierda suma de fila
                            if (ma[x, y - 1] == "N") { ma[x, y - 2] = "PO"; }

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

            Label1.Text = "LE TOCA A: " + colorturno;
            if (colorturno == "blanco")
            {
                b = 0;
                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "B")

                        {

                            //arriba suma de fila
                            if (ma[x + 1, y] == "N")
                            {

                                for (int z = x; z < 9; z++)
                                {
                                    if (ma[z, y] == " " && ma[z - 1, y] == "N")
                                    {
                                        ma[z, y] = "PA"; z = 9;
                                        b++;
                                    }
                                }
                            }

                            //abajo suma de fila
                            if (ma[x - 1, y] == "N")
                            {
                                for (int z = x; z > 0; z--)
                                {
                                    if (ma[z, y] == " " && ma[z + 1, y] == "N") { ma[z, y] = "PE"; z = 0; b++; }
                                }
                            }


                            //derecha suma de fila
                            if (ma[x, y + 1] == "N")
                            {
                                for (int z = y; z < 9; z++)
                                {
                                    if (ma[x, z] == " " && ma[x, z - 1] == "N") { ma[x, z] = "PI"; z = 9; b++; }
                                }
                            }
                            //izquierda suma de fila
                            if (ma[x, y - 1] == "N")
                            {
                                for (int z = y; z > 0; z--)
                                {
                                    if (ma[x, z] == " " && ma[x, z + 1] == "N") { ma[x, z] = "PO"; z = 0; b++; }
                                }
                            }


                        }

                    }
                }

                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "B")

                        {
                            //diaagonal 1  IZQUIERDA INFERIOR
                            if (ma[x - 1, y + 1] == "N")
                            {
                                for (int z = x; z > 0; z--)
                                {
                                    if (ma[z, y] == " " && ma[z + 1, y - 1] == "N")
                                    {
                                        ma[z, y] = "MA"; z = 0; b++;
                                    }
                                    y++;
                                    if (y > 8) { break; }
                                }
                            }

                            //diaagonal 2 DERECHA SPERIOR
                            if (ma[x + 1, y - 1] == "N")
                            {
                                for (int z = y; z > 0; z--)
                                {
                                    if (ma[x, z] == " " && ma[x - 1, z + 1] == "N")
                                    {
                                        ma[x, z] = "ME"; z = 0; b++;
                                    }
                                    x++;
                                    if (x > 8) { break; }
                                }
                            }




                        }


                    }
                }
            }


            if (colorturno == "negro")
            {
                n = 0;
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
                                        n++;
                                    }
                                }
                            }

                            //abajo suma de fila
                            if (ma[x - 1, y] == "B")
                            {
                                for (int z = x; z > 0; z--)
                                {
                                    if (ma[z, y] == " " && ma[z + 1, y] == "B") { ma[z, y] = "PE"; z = 0; n++; }
                                }
                            }


                            //derecha suma de fila
                            if (ma[x, y + 1] == "B")
                            {
                                for (int z = y; z < 9; z++)
                                {
                                    if (ma[x, z] == " " && ma[x, z - 1] == "B") { ma[x, z] = "PI"; z = 9; n++; }
                                }
                            }
                            //izquierda suma de fila
                            if (ma[x, y - 1] == "B")
                            {
                                for (int z = y; z > 0; z--)
                                {
                                    if (ma[x, z] == " " && ma[x, z + 1] == "B") { ma[x, z] = "PO"; z = 0; n++; }
                                }
                            }


                        }
                    }

                }



                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                    {
                        if (ma[x, y] == "N")

                        {
                            //diaagonal 1  IZQUIERDA INFERIOR
                            if (ma[x - 1, y + 1] == "B")
                            {
                                for (int z = x; z > 0; z--)
                                {
                                    if (ma[z, y] == " " && ma[z - 1, y + 1] == "B")
                                    {
                                        ma[z, y] = "MA"; z = 0; n++;
                                    }
                                    y++;
                                    if (y > 8) { break; }
                                }
                            }

                            //diaagonal 2 DERECHA SPERIOR
                            if (ma[x + 1, y - 1] == "B")
                            {
                                for (int z = y; z > 0; z--)
                                {
                                    if (ma[x, z] == " " && ma[x - 1, z + 1] == "B")
                                    {
                                        ma[x, z] = "ME"; z = 0; n++;
                                    }
                                    x++;
                                    if (x > 8) { break; }
                                }
                            }


                        }
                    }

                }

            }




            if (b == 0 && n == 0)
            {
                resultado();
            }

        }


    

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void a01_Click(object sender, EventArgs e)
        {

            if (colorturno == "blanco")
            {
                a01.BackColor = System.Drawing.Color.White;
                recorrer(1, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a01.BackColor = System.Drawing.Color.Black;
                recorrer(1, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }



        protected void b01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b01.BackColor = System.Drawing.Color.White;
                recorrer(2, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b01.BackColor = System.Drawing.Color.Black;
                recorrer(2, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        public void a10()
        {
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    ma[z, y] = " ";
                }
            }

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
                                colorlogeado= lectura.ReadString();
                                estado = "falso";
                                break;

                        }


                    }

                }

                if ((colorito == "blanco"))
                {
                    if ((fila == "1") && (columna == "A")) { ma[1, 1] = "B"; a01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "A")) { ma[1, 2] = "B"; a02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "A")) { ma[1, 3] = "B"; a03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "A")) { ma[1, 4] = "B"; a04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "A")) { ma[1, 5] = "B"; a05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "A")) { ma[1, 6] = "B"; a06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "A")) { ma[1, 7] = "B"; a07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "A")) { ma[1, 8] = "B"; a08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "B")) { ma[2, 1] = "B"; b01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "B")) { ma[2, 2] = "B"; b02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "B")) { ma[2, 3] = "B"; b03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "B")) { ma[2, 4] = "B"; b04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "B")) { ma[2, 5] = "B"; b05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "B")) { ma[2, 6] = "B"; b06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "B")) { ma[2, 7] = "B"; b07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "B")) { ma[2, 8] = "B"; b08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "C")) { ma[3, 1] = "B"; c1.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "C")) { ma[3, 2] = "B"; c02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "C")) { ma[3, 3] = "B"; c03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "C")) { ma[3, 4] = "B"; c04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "C")) { ma[3, 5] = "B"; c05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "C")) { ma[3, 6] = "B"; c06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "C")) { ma[3, 7] = "B"; c07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "C")) { ma[3, 8] = "B"; c08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "D")) { ma[4, 1] = "B"; d01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "D")) { ma[4, 2] = "B"; d02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "D")) { ma[4, 3] = "B"; d03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "D")) { ma[4, 4] = "B"; d04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "D")) { ma[4, 5] = "B"; d05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "D")) { ma[4, 6] = "B"; d06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "D")) { ma[4, 7] = "B"; d07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "D")) { ma[4, 8] = "B"; d08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "E")) { ma[5, 1] = "B"; e01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "E")) { ma[5, 2] = "B"; e02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "E")) { ma[5, 3] = "B"; e03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "E")) { ma[5, 4] = "B"; e04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "E")) { ma[5, 5] = "B"; e05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "E")) { ma[5, 6] = "B"; e06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "E")) { ma[5, 7] = "B"; e07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "E")) { ma[5, 8] = "B"; e08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "F")) { ma[6, 1] = "B"; f01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "F")) { ma[6, 2] = "B"; f02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "F")) { ma[6, 3] = "B"; f03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "F")) { ma[6, 4] = "B"; f04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "F")) { ma[6, 5] = "B"; f05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "F")) { ma[6, 6] = "B"; f06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "F")) { ma[6, 7] = "B"; f07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "F")) { ma[6, 8] = "B"; f08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "G")) { ma[7, 1] = "B"; g01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "G")) { ma[7, 2] = "B"; g02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "G")) { ma[7, 3] = "B"; g03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "G")) { ma[7, 4] = "B"; g04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "G")) { ma[7, 5] = "B"; g05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "G")) { ma[7, 6] = "B"; g06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "G")) { ma[7, 7] = "B"; g07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "G")) { ma[7, 8] = "B"; g08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "H")) { ma[8, 1] = "B"; h01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "H")) { ma[8, 2] = "B"; h02.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "H")) { ma[8, 3] = "B"; h03.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "H")) { ma[8, 4] = "B"; h04.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "H")) { ma[8, 5] = "B"; h05.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "H")) { ma[8, 6] = "B"; h06.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "H")) { ma[8, 7] = "B"; h07.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "H")) { ma[8, 8] = "B"; h08.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = ""; }



                }
                else
                {
                    if ((fila == "1") && (columna == "A")) { ma[1, 1] = "N"; a01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "A")) { ma[1, 2] = "N"; a02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "A")) { ma[1, 3] = "N"; a03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "A")) { ma[1, 4] = "N"; a04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "A")) { ma[1, 5] = "N"; a05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "A")) { ma[1, 6] = "N"; a06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "A")) { ma[1, 7] = "N"; a07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "A")) { ma[1, 8] = "N"; a08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "B")) { ma[2, 1] = "N"; b01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "B")) { ma[2, 2] = "N"; b02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "B")) { ma[2, 3] = "N"; b03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "B")) { ma[2, 4] = "N"; b04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "B")) { ma[2, 5] = "N"; b05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "B")) { ma[2, 6] = "N"; b06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "B")) { ma[2, 7] = "N"; b07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "B")) { ma[2, 8] = "N"; b08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "C")) { ma[3, 1] = "N"; c1.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "C")) { ma[3, 2] = "N"; c02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "C")) { ma[3, 3] = "N"; c03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "C")) { ma[3, 4] = "N"; c04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "C")) { ma[3, 5] = "N"; c05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "C")) { ma[3, 6] = "N"; c06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "C")) { ma[3, 7] = "N"; c07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "C")) { ma[3, 8] = "N"; c08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "D")) { ma[4, 1] = "N"; d01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "D")) { ma[4, 2] = "N"; d02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "D")) { ma[4, 3] = "N"; d03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "D")) { ma[4, 4] = "N"; d04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "D")) { ma[4, 5] = "N"; d05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "D")) { ma[4, 6] = "N"; d06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "D")) { ma[4, 7] = "N"; d07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "D")) { ma[4, 8] = "N"; d08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "E")) { ma[5, 1] = "N"; e01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "E")) { ma[5, 2] = "N"; e02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "E")) { ma[5, 3] = "N"; e03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "E")) { ma[5, 4] = "N"; e04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "E")) { ma[5, 5] = "N"; e05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "E")) { ma[5, 6] = "N"; e06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "E")) { ma[5, 7] = "N"; e07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "E")) { ma[5, 8] = "N"; e08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "F")) { ma[6, 1] = "N"; f01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "F")) { ma[6, 2] = "N"; f02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "F")) { ma[6, 3] = "N"; f03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "F")) { ma[6, 4] = "N"; f04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "F")) { ma[6, 5] = "N"; f05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "F")) { ma[6, 6] = "N"; f06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "F")) { ma[6, 7] = "N"; f07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "F")) { ma[6, 8] = "N"; f08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "G")) { ma[7, 1] = "N"; g01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "G")) { ma[7, 2] = "N"; g02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "G")) { ma[7, 3] = "N"; g03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "G")) { ma[7, 4] = "N"; g04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "G")) { ma[7, 5] = "N"; g05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "G")) { ma[7, 6] = "N"; g06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "G")) { ma[7, 7] = "N"; g07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "G")) { ma[7, 8] = "N"; g08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }

                    if ((fila == "1") && (columna == "H")) { ma[8, 1] = "N"; h01.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "2") && (columna == "H")) { ma[8, 2] = "N"; h02.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "3") && (columna == "H")) { ma[8, 3] = "N"; h03.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "4") && (columna == "H")) { ma[8, 4] = "N"; h04.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "5") && (columna == "H")) { ma[8, 5] = "N"; h05.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "6") && (columna == "H")) { ma[8, 6] = "N"; h06.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "7") && (columna == "H")) { ma[8, 7] = "N"; h07.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                    if ((fila == "8") && (columna == "H")) { ma[8, 8] = "N"; h08.BackColor = System.Drawing.Color.Black; colorito = ""; fila = ""; columna = ""; }
                }


            }




        }


        protected void a02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a02.BackColor = System.Drawing.Color.White;
                recorrer(1, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a02.BackColor = System.Drawing.Color.Black;
                recorrer(1, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a03.BackColor = System.Drawing.Color.White;
                recorrer(1, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a03.BackColor = System.Drawing.Color.Black;
                recorrer(1, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a04.BackColor = System.Drawing.Color.White;
                recorrer(1, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a04.BackColor = System.Drawing.Color.Black;
                recorrer(1, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a05.BackColor = System.Drawing.Color.White;
                recorrer(1, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a05.BackColor = System.Drawing.Color.Black;
                recorrer(1, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a06.BackColor = System.Drawing.Color.White;
                recorrer(1, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a06.BackColor = System.Drawing.Color.Black;
                recorrer(1, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a07.BackColor = System.Drawing.Color.White;
                recorrer(1, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a07.BackColor = System.Drawing.Color.Black;
                recorrer(1, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void a08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                a08.BackColor = System.Drawing.Color.White;
                recorrer(1, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                a08.BackColor = System.Drawing.Color.Black;
                recorrer(1, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b02.BackColor = System.Drawing.Color.White;
                recorrer(2, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b02.BackColor = System.Drawing.Color.Black;
                recorrer(2, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b03.BackColor = System.Drawing.Color.White;
                recorrer(2, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b03.BackColor = System.Drawing.Color.Black;
                recorrer(2, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b04.BackColor = System.Drawing.Color.White;
                recorrer(2, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b04.BackColor = System.Drawing.Color.Black;
                recorrer(2, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b05.BackColor = System.Drawing.Color.White;
                recorrer(2, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b05.BackColor = System.Drawing.Color.Black;
                recorrer(2, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b06.BackColor = System.Drawing.Color.White;
                recorrer(2, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b06.BackColor = System.Drawing.Color.Black;
                recorrer(2, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b07.BackColor = System.Drawing.Color.White;
                recorrer(2, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b07.BackColor = System.Drawing.Color.Black;
                recorrer(2, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void b08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                b08.BackColor = System.Drawing.Color.White;
                recorrer(2, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                b08.BackColor = System.Drawing.Color.Black;
                recorrer(2, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c1.BackColor = System.Drawing.Color.White;
                recorrer(3, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c1.BackColor = System.Drawing.Color.Black;
                recorrer(3, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c02.BackColor = System.Drawing.Color.White;
                recorrer(3, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c02.BackColor = System.Drawing.Color.Black;
                recorrer(3, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c03.BackColor = System.Drawing.Color.White;
                recorrer(3, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c03.BackColor = System.Drawing.Color.Black;
                recorrer(3, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c04.BackColor = System.Drawing.Color.White;
                recorrer(3, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c04.BackColor = System.Drawing.Color.Black;
                recorrer(3, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();

            }
        }

        protected void c05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c05.BackColor = System.Drawing.Color.White;
                recorrer(3, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c05.BackColor = System.Drawing.Color.Black;
                recorrer(3, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c06.BackColor = System.Drawing.Color.White;
                recorrer(3, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c06.BackColor = System.Drawing.Color.Black;
                recorrer(3, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c07.BackColor = System.Drawing.Color.White;
                recorrer(3, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c07.BackColor = System.Drawing.Color.Black;
                recorrer(3, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void c08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                c08.BackColor = System.Drawing.Color.White;
                recorrer(3, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                c08.BackColor = System.Drawing.Color.Black;
                recorrer(3, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d01.BackColor = System.Drawing.Color.White;
                recorrer(4, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                d01.BackColor = System.Drawing.Color.Black;
                recorrer(4, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d02.BackColor = System.Drawing.Color.White;
                recorrer(4, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                d02.BackColor = System.Drawing.Color.Black;
                recorrer(4, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d03.BackColor = System.Drawing.Color.White;

                recorrer(4, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();

            }
            else
            {
                d03.BackColor = System.Drawing.Color.Black;
                recorrer(4, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d04_Click(object sender, EventArgs e)
        {



            if (colorturno == "blanco")
            {
                d04.BackColor = System.Drawing.Color.White;
                ma[4, 4] = "B";
                colorturno = "negro";
            }
            else
            {
                d04.BackColor = System.Drawing.Color.Black;
                ma[4, 4] = "N";
                colorturno = "blanco";
               
            }
            int w = 0;
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[z, y] == "B") { w++; }
                    if (ma[z, y] == "N") { w++; }
                }
            }
            if (w==4) {
                tabla1();
                posibles();
            }

        }

        protected void d05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d05.BackColor = System.Drawing.Color.White;
                ma[4, 5] = "B";
                colorturno = "negro";
            }
            else
            {
                d05.BackColor = System.Drawing.Color.Black;
                ma[4, 5] = "N";
                colorturno = "blanco";
                
            }

            int w = 0;
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[z, y] == "B") { w++; }
                    if (ma[z, y] == "N") { w++; }
                }
            }
            if (w == 4)
            {
                tabla1();
                posibles();
            }

        }

        protected void d06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d06.BackColor = System.Drawing.Color.White;
                recorrer(4, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                d06.BackColor = System.Drawing.Color.Black; colorturno = "blanco";
                recorrer(4, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();

            }

        }

        protected void d07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d07.BackColor = System.Drawing.Color.White;
                recorrer(4, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                d07.BackColor = System.Drawing.Color.Black;
                recorrer(4, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void d08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                d08.BackColor = System.Drawing.Color.White;
                recorrer(4, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                d08.BackColor = System.Drawing.Color.Black;
                recorrer(4, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e01.BackColor = System.Drawing.Color.White;
                recorrer(5, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                e01.BackColor = System.Drawing.Color.Black;
                recorrer(5, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }

        }

        protected void e02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e02.BackColor = System.Drawing.Color.White;
                recorrer(5, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                e02.BackColor = System.Drawing.Color.Black;
                recorrer(5, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e03.BackColor = System.Drawing.Color.White;
                recorrer(5, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                e03.BackColor = System.Drawing.Color.Black;
                recorrer(5, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e04.BackColor = System.Drawing.Color.White;
                ma[5, 4] = "B";
                colorturno = "negro";
            }
            else
            {
                e04.BackColor = System.Drawing.Color.Black;
                ma[5, 4] = "N";
                colorturno = "blanco";
            }

            int w = 0;
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[z, y] == "B") { w++; }
                    if (ma[z, y] == "N") { w++; }
                }
            }
            if (w == 4)
            {
                tabla1();
                posibles();
            }
        }



        protected void e06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e06.BackColor = System.Drawing.Color.White;
                recorrer(5, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                e06.BackColor = System.Drawing.Color.Black;
                recorrer(5, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e07.BackColor = System.Drawing.Color.White;
                recorrer(5, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                e07.BackColor = System.Drawing.Color.Black;
                recorrer(5, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void e08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e08.BackColor = System.Drawing.Color.White;
                recorrer(5, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                e08.BackColor = System.Drawing.Color.Black;
                recorrer(5, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f01.BackColor = System.Drawing.Color.White;
                recorrer(6, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f01.BackColor = System.Drawing.Color.Black;
                recorrer(6, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f02.BackColor = System.Drawing.Color.White;
                recorrer(6, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f02.BackColor = System.Drawing.Color.Black;
                recorrer(6, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f03.BackColor = System.Drawing.Color.White;
                recorrer(6, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f03.BackColor = System.Drawing.Color.Black;
                recorrer(6, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f04.BackColor = System.Drawing.Color.White;
                recorrer(6, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();

            }
            else
            {
                f04.BackColor = System.Drawing.Color.Black;
                recorrer(6, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f05.BackColor = System.Drawing.Color.White;
                recorrer(6, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f05.BackColor = System.Drawing.Color.Black;
                recorrer(6, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f06.BackColor = System.Drawing.Color.White;
                recorrer(6, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f06.BackColor = System.Drawing.Color.Black;
                recorrer(6, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f07.BackColor = System.Drawing.Color.White;
                recorrer(6, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f07.BackColor = System.Drawing.Color.Black;
                recorrer(6, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void f08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                f08.BackColor = System.Drawing.Color.White;
                recorrer(6, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                f08.BackColor = System.Drawing.Color.Black;
                recorrer(6, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g01.BackColor = System.Drawing.Color.White;
                recorrer(7, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();

            }
            else
            {
                g01.BackColor = System.Drawing.Color.Black;
                recorrer(7, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g02.BackColor = System.Drawing.Color.White;
                recorrer(7, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g02.BackColor = System.Drawing.Color.Black;
                recorrer(7, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g03.BackColor = System.Drawing.Color.White;
                recorrer(7, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g03.BackColor = System.Drawing.Color.Black;
                recorrer(7, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g04.BackColor = System.Drawing.Color.White;
                recorrer(7, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g04.BackColor = System.Drawing.Color.Black;
                recorrer(7, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g05.BackColor = System.Drawing.Color.White;
                recorrer(7, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g05.BackColor = System.Drawing.Color.Black;
                recorrer(7, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g06.BackColor = System.Drawing.Color.White;
                recorrer(7, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g06.BackColor = System.Drawing.Color.Black;
                recorrer(7, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g07.BackColor = System.Drawing.Color.White;
                recorrer(7, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g07.BackColor = System.Drawing.Color.Black;
                recorrer(7, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void g08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                g08.BackColor = System.Drawing.Color.White;
                recorrer(7, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                g08.BackColor = System.Drawing.Color.Black;
                recorrer(7, 8, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h01.BackColor = System.Drawing.Color.White;
                recorrer(8, 1, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h01.BackColor = System.Drawing.Color.Black;
                recorrer(8, 1, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h02.BackColor = System.Drawing.Color.White;
                recorrer(8, 2, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h02.BackColor = System.Drawing.Color.Black;
                recorrer(8, 2, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h03.BackColor = System.Drawing.Color.White;
                recorrer(8, 3, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h03.BackColor = System.Drawing.Color.Black;
                recorrer(8, 3, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h04.BackColor = System.Drawing.Color.White;
                recorrer(8, 4, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h04.BackColor = System.Drawing.Color.Black;
                recorrer(8, 4, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h05.BackColor = System.Drawing.Color.White;
                recorrer(8, 5, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h05.BackColor = System.Drawing.Color.Black;
                recorrer(8, 5, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h06.BackColor = System.Drawing.Color.White;
                recorrer(8, 6, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h06.BackColor = System.Drawing.Color.Black;
                recorrer(8, 6, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h07.BackColor = System.Drawing.Color.White;
                recorrer(8, 7, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h07.BackColor = System.Drawing.Color.Black;
                recorrer(8, 7, "N");
                mostrar();
                colorturno = "blanco";
                tabla1();
                posibles();
            }
        }

        protected void h08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                h08.BackColor = System.Drawing.Color.White;
                recorrer(8, 8, "B");
                mostrar();
                colorturno = "negro";
                tabla1();
                posibles();
            }
            else
            {
                h08.BackColor = System.Drawing.Color.Black;
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
            a01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a100.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            a20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            b01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            b20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            c1.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            c20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            d01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            d20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            e01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            e20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            f01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            f20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            g01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            g20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            h01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            h20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            i01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            i20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            j01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            j20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            k01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            k20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            l01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            l20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            mm01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            mm19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
           mm20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            n01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            n20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            ñ01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ñ20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            o20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        
            p01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            p20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
        
            q01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            q20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            r01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            r20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            ss01.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss02.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss03.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss04.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss05.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss06.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss07.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss08.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss9.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss10.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss11.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss12.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss13.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss14.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss15.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss16.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss17.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss18.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss19.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            ss20.BackColor = System.Drawing.ColorTranslator.FromHtml("#000000");

            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    ma[z, y] = " ";
                }
            }
            tiempoj1 = 0;
            tiempoj2 = 0;
            tiempoj2m = 0;
            tiempoj1m = 0;

        }

        protected void e05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco")
            {
                e05.BackColor = System.Drawing.Color.White;
                ma[5, 5] = "B";
                colorturno = "negro";
            }
            else
            {
                e05.BackColor = System.Drawing.Color.Black;
                ma[5, 5] = "N";
                colorturno = "blanco";
            }

            int w = 0;
            for (int z = 0; z < 9; z++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (ma[z, y] == "B") { w++; }
                    if (ma[z, y] == "N") { w++; }
                }
            }
            if (w == 4)
            {
                tabla1();
                posibles();
            }
        }

       

        protected void Button3_Click(object sender, EventArgs e)
        {
            colorturno = "negro";
            colorlogeado = "blanco";
            Timer1.Enabled = true;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    
                        ma[x, y] = " ";
                   
                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            colorturno = "blanco";
            colorlogeado = "negro";

            Timer1.Enabled = true;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {

                    ma[x, y] = " ";

                }
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            if (colorturno == "negro") {
                s1.Text = ":" + tiempoj1;
                if (tiempoj1 == 60) { tiempoj1 = 0; tiempoj1m++; m1.Text = "" + tiempoj1m; }
                    tiempoj1++;
            }
            if (colorturno == "blanco")
            {
                s2.Text = ":" + tiempoj2;
                if (tiempoj2 == 60) { tiempoj2 = 0; tiempoj2m++; m2.Text = "" + tiempoj2m; }
                tiempoj2++;
            }

        }




        public void tablero()
        {

           
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;


            for (int z = 0; z < 20; z++)
            {
                a01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                a02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                a03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                a04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                a05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                a06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                a100.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                a20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
                aa = 1;
                b01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                b10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }  
                aa++;
                b19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }


        }




        public void tablerob()
        {

            
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;


            for (int z = 0; z < 20; z++)
            {
                
                //     -------------------------------------
                aa = 1;
                b01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                b06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                b10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                b20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------

            }
        }


        public void tableroc()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                c1.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                c02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                c03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                c04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                c05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                c06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                c10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                c20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------

            }
        }


        public void tablerod()
        {


            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;


            for (int z = 0; z < 20; z++)
            {

                //     -------------------------------------
                aa = 1;
                d01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                d02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                d03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                d04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                d05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                d06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                d10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                d20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------

            }

        }

        public void tableroe()
        {


            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;


            for (int z = 0; z < 20; z++)
            {

                //     -------------------------------------
                aa = 1;
                e01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                e02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                e03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                e04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                e05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                e06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                e10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                e20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------

            }
        }


        public void tablerof()
        {


            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;


            for (int z = 0; z < 20; z++)
            {

                //     -------------------------------------
                aa = 1;
                f01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                f02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                f03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                f04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                f05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                f06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                f10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                f20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tablerog()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                g01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                g02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                g03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                g04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                g05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                g06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                g10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                g20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableroh()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                h01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                h02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                h03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                h04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                h05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                h06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                h10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                h20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableroi()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                i01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                i02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                i03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                i04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                i05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                i06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                i10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                i20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableroj()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                j01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                j02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                j03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                j04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                j05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                j06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                j10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                j20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tablerok()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                k01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                k02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                k03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                k04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                k05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                k06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                k10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                k20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tablerol()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                l01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                l02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                l03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                l04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                l05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                l06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                l10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                l20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tablerom()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                mm01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                mm02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                mm03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                mm04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                mm05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                mm06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                mm10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                mm20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableron()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                n01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                n02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                n03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                n04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                n05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                n06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                n10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                n20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableroñ()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                ñ01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ñ02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ñ03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ñ04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ñ05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ñ06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                ñ10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ñ20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableroo()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                o01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                o02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                o03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                o04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                o05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                o06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                o10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                o20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tablerop()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                p01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                p02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                p03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                p04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                p05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                p06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                p10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                p20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableroq()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                q01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                q02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                q03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                q04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                q05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                q06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                q10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                q20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableror()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                r01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                r02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                r03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                r04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                r05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                r06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                r10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                r20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }

        public void tableros()
        {
            int y = Int32.Parse(TextBox2.Text);
            int aa = 1;
            int xx = 1;

            for (int z = 0; z < 20; z++)
            {
                //     -------------------------------------
                aa = 1;
                ss01.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ss02.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ss03.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ss04.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ss05.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                aa++;
                ss06.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;

                ss10.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                aa++;
                ss20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (y == aa) { return; }
                //     -------------------------------------
            }
        }








        protected void Button6_Click(object sender, EventArgs e)
        {
            


        }

        protected void insertar_Click(object sender, EventArgs e)
        {

            int y = Int32.Parse(TextBox1.Text);
            tablero();
            tablerob();
            tableroc();
            tablerod();
            tableroe();
            tablerof();
            if (y == 7) { tablerog(); }
            if (y == 8) { tablerog(); tableroh(); }
            if (y == 9) { tablerog(); tableroh(); tableroi(); }
            if (y == 10) { tablerog(); tableroh(); tableroi(); tableroj(); }
            if (y == 11) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); }
            if (y == 12) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); }
            if (y == 13) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); }
            if (y == 14) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); }
            if (y == 15) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); tableroñ(); }
            if (y == 16) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); tableroñ(); tableroo(); }
            if (y == 17) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); tableroñ(); tableroo(); tablerop(); }
            if (y == 18) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); tableroñ(); tableroo(); tablerop();  tableroq(); }
            if (y == 19) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); tableroñ(); tableroo(); tablerop(); tableroq(); tableror(); }
            if (y == 20) { tablerog(); tableroh(); tableroi(); tableroj(); tablerok(); tablerol(); tablerom(); tableron(); tableroñ(); tableroo(); tablerop(); tableroq(); tableror(); tableros(); }


        }
    }

}