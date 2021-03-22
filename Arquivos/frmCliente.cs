using MetroFramework.Controls;
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
    public partial class frmCliente : MetroFramework.Forms.MetroForm
    {
        public frmCliente()
        {
            InitializeComponent();
            CarregarDados();
        }
        public void CarregarDados()
        {
            CsBanco.CarregaDados("select id,nome,apelido,aniversario from tb_cliente where deletado = 'não';", metroGrid1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtApelido.Text == "" || txtNome.Text == "")
            {
                MessageBox.Show("Preencha os campos nome e apelido ", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();

            }
            else
            {
                try
                {
                    CsBanco.ExecutarComandoSQL("insert into tb_cliente ('nome','apelido','aniversario','deletado') values ('" + txtNome.Text + "','" + txtApelido.Text + "','" + txtNascimento.Text + "','não');");
                    CsFuncoes.Mensagem("Inserido com sucesso !", txtNome.Text + " Foi cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    CsFuncoes.MensagemERRO_PADRAO(ex);
                }
            }
            CarregarDados();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtNascimento.Text = dateTimePicker1.Value.ToShortDateString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                CsBanco.ExecutarComandoSQL("update tb_cliente set nome='" + txtNome.Text + "',apelido='" + txtApelido.Text + "',aniversario='" + txtNascimento.Text + "' where id = '" + txtID.Text + "'");
                CsFuncoes.Mensagem("Atualizado !", txtNome.Text + " Foi Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            CarregarDados();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Isso sera permanente","Excluindo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CsBanco.ExecutarComandoSQL("update tb_cliente set deletado='sim' where id = '" + txtID.Text + "'");
                    CsFuncoes.Mensagem("Excluido !", txtNome.Text + " Foi Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDados();
                    txtApelido.Text = "";
                    txtID.Text = "";
                    txtNascimento.Text = "";
                    txtNome.Text = "";

                }
                else
                {

                }
                
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            CarregarDados();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtApelido.Text = "";
            txtID.Text = "";
            txtNascimento.Text = "";
            txtNome.Text = "";

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtApelido.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            txtNascimento.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
