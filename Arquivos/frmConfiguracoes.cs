using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class frmConfiguracoes : MetroFramework.Forms.MetroForm
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Comercio.Properties.Settings.Default.nomeDoSistema = metroTextBox1.Text;
            Properties.Settings.Default.Save();
            CsFuncoes.Mensagem("Reinicie o sistema !", "Tudo pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
