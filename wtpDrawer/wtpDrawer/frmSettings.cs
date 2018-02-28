using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace wtpDrawer
{
    public partial class frmSettings : Form
    {

        int max = 0;

        public frmSettings(int max)
        {
            InitializeComponent();
            this.max = max;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            nAltura.Maximum = max;

            nAltura.Value = Math.Min(Properties.Settings.Default.Max, max);
            nEscala.Value = Properties.Settings.Default.Escala;

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Max = Convert.ToInt32(nAltura.Value);
            Properties.Settings.Default.Escala = Convert.ToInt32(nEscala.Value);
            Properties.Settings.Default.Save();

            this.Close();

        }
    }
}
