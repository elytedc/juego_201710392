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
                    a010();
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

        public void a010()
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
            string p =TextBox1.Text;
            int n = p;
            int aa = 1;

            
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
                if (n == aa) { return; }
                aa++;
                a07.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a08.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a9.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a010.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a11.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a12.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a13.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a14.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a15.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a16.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a17.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a18.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a19.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
                aa++;
                a20.BackColor = System.Drawing.ColorTranslator.FromHtml("#009E0C");
                if (n == aa) { return; }
            }
            

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            tablero(6);
        }
    }

}