using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class principal : MetroFramework.Forms.MetroForm
    {
        public principal()
        {
            InitializeComponent();
            reloaddata();
            //MessageBox.Show(Properties.Settings.Default.registro);
            Properties.Settings.Default.registro = CsBanco.VerificarMac(Properties.Settings.Default.registro);
            Properties.Settings.Default.Save();
            //MessageBox.Show(Properties.Settings.Default.registro);
            VerificarRegistro();
            File.Delete(Directory.GetCurrentDirectory() + "\\Registrar.exe");
            CsBanco.teste(lblVersaoTeste,btnAgendamento, btnCliente, btnRelatorio, btnTeste);
            VerificarRegistro();
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            
            
          
            
            
                
            
        }
      
        public void VerificarRegistro()
        {
            //verificar se esta registrado
            
            
            string mac = "", registro = "";
            registro = Properties.Settings.Default.registro;
            mac = CsBanco.PegarMac(mac);
           //MessageBox.Show("Verificar mac:"+mac +"\nRegistro mac: " +registro);
            

            if (registro == mac)
            {
                //CsFuncoes.Mensagem("Seu Software não esta registrado, entra em contato com o vendedor", "Produto não registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAgendamento.Enabled = true;
                btnCliente.Enabled = true;
                btnConfiguracao.Enabled = true;
                btnRelatorio.Enabled = true;
                btnSair.Enabled = true;
                btnSuporte.Enabled = true;
                btnTeste.Visible = false;
                lblVersaoTeste.Visible = false;
            }
            else
            {
                //CsFuncoes.Mensagem("Seu Software não esta registrado, entra em contato com o vendedor\nAs Funções estarão limitadas", "Produto não registrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                


            }
            //MessageBox.Show("mac" + mac + "registro " + registro);

        }
        public void reloaddata()
        {
            CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido from tb_horario where data >= '" + DateTime.Now.ToShortDateString() + "' and veio ='não' and deletado = 'não';", metroGrid1);
            this.Text = Properties.Settings.Default.nomeDoSistema;

            //select * from tb_horario WHERE data >= "20/10/2020" and deletado ='não';
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmCliente w = new frmCliente();
            w.ShowDialog();
            reloaddata();

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmAgendarNovo w = new frmAgendarNovo();
            w.ShowDialog();
            reloaddata();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioAgendamento w = new frmRelatorioAgendamento();
            w.ShowDialog();
            reloaddata();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioCliente w = new frmRelatorioCliente();
            w.ShowDialog();
            reloaddata();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            CsFuncoes.Mensagem("Meu whats para duvida ou contato\n 19 99697-3079\nMeu nome é Franklin", "Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void iniciarteste7Dias()
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*hoje
             * mais 7 dias aparecer a mensagem versão de teste se encerra hoje
            */
            string hoje = DateTime.Now.ToShortDateString();
            int diahoje = DateTime.Now.Day, mes = DateTime.Now.Month, ano = DateTime.Now.Year;
            int veraoteste = diahoje + 7;
            
            CsBanco.ExecutarComandoSQL("UPDATE tb_versaoTeste set dia ='" + diahoje + "', ultimoDia ='"+veraoteste+"' where id = '1';");
            //UPDATE tb_versaoTeste set dia ='22',ultimoDia = '29' where id =1;
            btnAgendamento.Enabled = true;
            btnCliente.Enabled = true;
            btnConfiguracao.Enabled = true;
            btnRelatorio.Enabled = true;
            btnSair.Enabled = true;
            lblVersaoTeste.Visible = true;
            

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoes w = new frmConfiguracoes();
            w.ShowDialog();
            this.Text = Properties.Settings.Default.nomeDoSistema;
            reloaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void lblVersaoTeste_Click(object sender, EventArgs e)
        {

        }
    }
}
