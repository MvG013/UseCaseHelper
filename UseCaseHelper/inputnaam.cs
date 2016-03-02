using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class inputnaam : Form
    {
        public string naam { get; private set; }
        public inputnaam(string vraag)
        {
            InitializeComponent();
            this.CenterToScreen();
            LblVraag.Text = vraag;
        }

        private void BtnOke_Click_1(object sender, EventArgs e)
        {
            naam = TbNaam.Text;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
