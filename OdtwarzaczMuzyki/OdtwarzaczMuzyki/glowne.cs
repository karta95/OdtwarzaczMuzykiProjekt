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
        oknoEdycji _oknoEdycji;
        oknoPobierania _oknoPobierania;
        public glowne()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
           
        }

        private void main_Resize(object sender, EventArgs e)
        {
    
        }

        private void mójProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oknoEdycji = new oknoEdycji();
            _oknoEdycji.ShowDialog();

        }

        private void pobierzZYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _oknoPobierania = new oknoPobierania();
            _oknoPobierania.ShowDialog();
        }
    }
}
