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
    public partial class glowne : Form
    {
        public glowne()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            pasekPostepu.ForeColor = Color.MediumPurple;
           
        }

        private void main_Resize(object sender, EventArgs e)
        {
    
        }

       
    }
}
