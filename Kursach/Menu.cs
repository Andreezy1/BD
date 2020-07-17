using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Dannie_Click(object sender, EventArgs e)
        {
            Dannie_Form dannie_form = new Dannie_Form();
            dannie_form.Show();
        }

        private void Mejgorod_Click(object sender, EventArgs e)
        {
            Mejgorod_Form form3 = new Mejgorod_Form();
            form3.Show();
        }

        private void Detalizaciya_Click(object sender, EventArgs e)
        {
            Detalizaciya form4 = new Detalizaciya();
            form4.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
