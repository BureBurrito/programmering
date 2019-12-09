using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positioner__Fungerande_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            tbxPosition.Text = "";
            Random MyRandom = new Random();
            int tal = MyRandom.Next(0, 246);
            string start = "https://www.sexpositions.club/positions/";
            string slut = ".html";
            tbxPosition.AppendText(start + tal + slut);
        }
    }
}
