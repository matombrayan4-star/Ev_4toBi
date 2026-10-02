using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_4toBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "Jacinto" && TextContraseña.Text == "91") ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
