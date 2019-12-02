using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Positioner
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
            string start = "sexpositions.club/positions/";
            string slut = ".html";
            tbxPosition.AppendText(start + tal + slut);
            string url = start + tal + slut;
            






        }
    }
}
