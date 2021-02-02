using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIMC
{
    public partial class frmIMC : Form
    {
        static Form2 f2 = new Form2();

        static Operacion op = new Operacion();

        public frmIMC()
        {
            InitializeComponent();
            
        }      
        private void button1_Click(object sender, EventArgs e)
        {
            lblResultado.Text = op.imc(double.Parse(txtpeso.Text), double.Parse(txtestatura.Text)).ToString();
        }
       
        private void frmIMC_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdtabl_Click(object sender, EventArgs e)
        {
            f2.Show();
        }
    }

 
}
