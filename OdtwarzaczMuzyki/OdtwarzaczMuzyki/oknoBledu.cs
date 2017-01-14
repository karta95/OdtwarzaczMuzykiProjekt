using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdtwarzaczMuzyki
{
    public partial class oknoBledu : Form
    {
        public oknoBledu(string blad)
        {
            InitializeComponent();
            bladLabel.Text = blad;
            this.Visible = true;

        }

        private void OKbutton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
