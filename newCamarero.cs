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
    public partial class newCamarero : Form
    {
        
        
        public String usuario;
        public String movil;
        public String nombre;
        public String turn;
        
      
        public newCamarero()
        {
            InitializeComponent();
            
            


        }
       
        

        private void newCamarero_Load(object sender, EventArgs e)
        {
            

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            usuario = txbUsuario.Text;
            movil = txbMovil.Text;
            nombre = txbNombre.Text;
            if (rdManana.Checked == true)
            {
                turn ="Mañana";
            }else if (rdTarde.Checked == true)
            {
                turn = "Tarde";
            }
           
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
