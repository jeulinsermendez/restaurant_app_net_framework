using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRestaurante
{
    
    public partial class Form4 : Form
    {
        public string numUsu;
        public String nummovil;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            
            try
            {
                numUsu = tbUsuario.Text;
                nummovil = tbMovil.Text;
                

                

                this.Close();
            }
            catch (System.FormatException sy)
            {
                MessageBox.Show(sy.Message);

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        
    }
}
