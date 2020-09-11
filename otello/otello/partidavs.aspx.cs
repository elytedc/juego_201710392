using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using Microsoft;
using System.Xml;
using System.IO;




namespace otello

{
    public partial class partidavs : System.Web.UI.Page
    {
        public static string colorito = "";
        public static  string fila = "";
        public static string columna = "";
        public static string estado = "falso";
        public static string colorturno = "";

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

       
        public void botones(string fila, string columna,string color)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void a01_Click(object sender, EventArgs e)
        { if (colorturno == "blanco") { a01.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a01.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }   }

        

        
        






        protected void b01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b01.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b01.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        public void a10()
        {
            string c = fUpload.FileName;
            string cadena= @"C:\Users\john\Desktop\ipc2\juego\juego_201710392\otello\otello\xml\" + c;
            XmlReader xmlreader = XmlReader.Create(cadena);
            

            while (xmlreader.Read())
            {
                if (xmlreader.IsStartElement()) {
                    if (estado == "falso")
                    {
                        switch (xmlreader.Name.ToString())
                        {
                            case "color":
                                colorito = xmlreader.ReadString();
                                break;
                            case "fila":
                                fila = xmlreader.ReadString();
                                break;
                            case "columna":
                                columna = xmlreader.ReadString();
                                break;
                            case "siguienteTiro":
                                estado = "verdadero";
                                break;


                        }
                    }
                    else {

                        switch (xmlreader.Name.ToString())
                        {
                            case "color":
                                colorturno = xmlreader.ReadString();
                                estado = "falso";
                                break;

                        }


                    }

                }

                 if ((colorito == "blanco")) {
                    if ((fila == "1") && (columna == "A")) { a01.BackColor = System.Drawing.Color.White; colorito = ""; fila = ""; columna = "";}
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

        protected void a103_Click(object sender, EventArgs e)
        {
            


        }

        protected void a02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a02.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a02.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void a03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a03.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a03.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void a04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a04.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a04.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void a05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a05.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a05.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void a06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a06.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a06.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void a07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a07.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a07.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void a08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { a08.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { a08.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b02.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b02.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b03.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b03.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b04.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b04.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b05.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b05.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b06.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b06.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b07.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b07.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void b08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { b08.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { b08.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c1_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c1.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c1.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c02.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c02.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c03.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c03.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c04.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c04.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c05.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c05.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c06.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c06.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c07.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c07.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void c08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { c08.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { c08.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d01_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d01.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d01.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d02_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d02.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d02.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d03_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d03.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d03.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d04_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d04.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d04.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d05_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d05.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d05.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d06_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d06.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d06.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d07_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d07.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d07.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }

        protected void d08_Click(object sender, EventArgs e)
        {
            if (colorturno == "blanco") { d08.BackColor = System.Drawing.Color.White; colorturno = "negro"; }
            else { d08.BackColor = System.Drawing.Color.Black; colorturno = "blanco"; }
        }
    }
}