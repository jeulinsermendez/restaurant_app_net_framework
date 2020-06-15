using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AppRestaurante
{
    public partial class Form1 : Form
    {
        Restaurante myRest;
        String usuario;
        String movil;
        String nombre;
        String turn;
        Boolean confirmado = false;
        Document doc = new Document();
       




        public Form1()
        {
            InitializeComponent();
            instantialize();
            //PdfWriter.GetInstance(doc, new FileStream("D:\\ejemplo\\example.pdf", FileMode.OpenOrCreate));
            doc.Open();

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Restaurante Jardi";
            lblNomUsuar.Text = "";
            lblNombre.Text = "";
            lblNumMov.Text = "";
            lblUserAd.Text = "";
            lblTurno.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void instantialize()
        {
            myRest = new Restaurante();
        }
        private void anaidir(Usuario userAd)
        {

        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            lblUserAd.Text = "";
            usuario = txbUsuario.Text;
            movil = txbMovil.Text;
            Usuario user = null;

           user = myRest.buscarCamarero(usuario, movil);

            if (user != null)
            {
                imprimirEnLabels(user);
                
                confirmado = true;
            }
            else
            {
                MessageBox.Show("Este usuariono existe");
                confirmado = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            newCamarero form2 = new newCamarero();
            Usuario userAd;
            Usuario userComp = null;


            form2.ShowDialog();
            
                usuario = form2.usuario;
                movil = form2.movil;
                nombre = form2.nombre;
                turn = form2.turn;
                userAd = new Usuario(form2.usuario, form2.movil, form2.nombre, form2.turn);
                myRest.addCamarero(userAd);
                userComp = myRest.buscarCamarero(userAd.nomUsuario, userAd.numTelefono);
                if (userComp != null)
                {
                lblUserAd.Text = "¡Se ha añadido un camarero!";

                imprimirEnLabels(userComp);
                    
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 generComens = new Form3();
            Form1 myProgra = new Form1();
                
            int mesasVacias = 0;
            int comens;
            int mesas;
           
            if (confirmado == false)
            {
                MessageBox.Show("Tiene que haver un usuario identificado");
            }
            else
            {
                generComens.ShowDialog();


                comens = generComens.comensales;
                mesas = generComens.comensales;

                if (comens < 0 || comens > 10 || mesas < 1 || mesas > 20)
                {
                    if (comens < 0 || comens > 10)
                    {
                        MessageBox.Show("EL numero de comensales es incorrecto");
                    }
                    if (mesas < 1 || mesas > 20)
                    {
                        MessageBox.Show("EL numero de mesas es incorrecto");
                    }
                }
                else
                {
                    String comen ="";
                    for (int j = 1; j <= mesas; j++)
                    {
                        mesasVacias = myProgra.rellenarComensales(comens);
                        if (mesasVacias == 0)
                        {
                            comen += "\r\nLa mesa  " + j + " esta vacia\r\n";
                            //doc.Add(new Paragraph("La mesa  " + j + " esta vacia"));
                        }
                        else
                        {
                            comen += "\r\nEn la mesa  " + j + " hay " + mesasVacias + " comensales\r\n";
                            // doc.Add(new Paragraph("En la mesa  " + j + " hay " + mesasVacias + " comensales"));
                        }
                    }
                    textBoxComen.Text = comen;
                }

            }
            


             

        }


        public int rellenarComensales(int comensalesR)
        {

            int num;
            int result;
            Random rnd = new Random();
            num = rnd.Next(1, comensalesR + 1);

            result = comensalesR - num;
            return result;
        }

        private void btnBuscClient_Click(object sender, EventArgs e)
        {
            Form4 buscadorCliente = new Form4();
            Boolean cliente = false;
            cliente =  myRest.buscarCliente(buscadorCliente.numUsu, buscadorCliente.nummovil);

            if (cliente == true)
            {
                MessageBox.Show("Cliente validado!");
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña no es correcta");
            }

        }

        private void imprimirEnLabels(Usuario user)
        {
            lblNomUsuar.Text = user.nomUsuario;
            lblNombre.Text = user.nombre;
            lblNumMov.Text = user.numTelefono;
            lblTurno.Text = user.turno;

        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            generaPDF(textBoxComen.Text);
        }
        private static void generaPDF(string paragraf)
        {

            try
            {

                Document document = new Document();

                PdfWriter.GetInstance(document,

                                     new FileStream("../../Archivos/ejemplo.pdf", FileMode.OpenOrCreate));

                document.Open();

                document.Add(new Paragraph(paragraf));

                document.Close();

            }
            catch (UnauthorizedAccessException err)
            {

                MessageBox.Show("Error de ruta");
            }
            catch (DirectoryNotFoundException er)
            {

                MessageBox.Show("Error de ruta");
            }
            
        }

        private void lbComensales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
