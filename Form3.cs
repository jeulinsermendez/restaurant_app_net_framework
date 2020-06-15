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
    public partial class Form3 : Form
    {
        public int comensales;
        public int mesas;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int comensPruba = 0;
                int mesasPruba = 0;



                comensales = Convert.ToInt32(tbComensales.Text);
                mesas = Convert.ToInt32(tbMesas.Text);



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
