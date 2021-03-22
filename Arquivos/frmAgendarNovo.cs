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
    public partial class frmAgendarNovo : MetroFramework.Forms.MetroForm
    {
        public frmAgendarNovo()
        {
            InitializeComponent();
            monthCalendar1.MinDate = DateTime.Now.Date;
            carregarclientes();
            carregarDados();
        }
        public void carregarclientes()
        {
            CsBanco.BuscarCliente(cbNome);
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtData.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
        string hora = "";
        private void numeric_Hora_ValueChanged(object sender, EventArgs e)
        {
            hora = numeric_Hora.Value.ToString() + ":" + numeric_Minutos.Value.ToString();
            txtHora.Text = hora;
        }

        private void numeric_Minutos_ValueChanged(object sender, EventArgs e)
        {
            hora = numeric_Hora.Value.ToString() + ":" + numeric_Minutos.Value.ToString();
            txtHora.Text = hora;
        }

        public void carregarDados()
        {
            CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido from tb_horario where data >= '"+DateTime.Now.ToShortDateString()+ "' and veio ='não' and deletado = 'não';", metroGrid1);
            
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtApelido.Text == "" || cbNome.Text == "" || txtServicos.Text =="" || txtData.Text ==""||txtHora.Text =="")
            {
                MessageBox.Show("Preencha os campos \nNome\nApelido\nServiços\nData\nHora\n\nAntes de salvar um horario ", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNome.Focus();

            }
            else
            {
                try
                {
                    CsBanco.ExecutarComandoSQL("insert into tb_horario ('data','horario','nome','apelido','servicos','veio','deletado') values ('" + txtData.Text + "','" + txtHora.Text + "','" + cbNome.Text + "','" + txtApelido.Text + "','" + txtServicos.Text + "','não','não');");
                    //CsBanco.ExecutarComandoSQL("insert into tb_cliente ('nome','apelido','deletado') values ('" + metroComboBox1.Text + "','" + txtApelido.Text + "','não');");
                    CsFuncoes.Mensagem("Nome: " + cbNome.Text + " \nData: " + txtData.Text + " \nHorario: " + txtHora.Text + "", cbNome.Text + " Agendamento concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    CsFuncoes.MensagemERRO_PADRAO(ex);
                }
            }
            carregarDados();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                CsBanco.ExecutarComandoSQL("update tb_horario set data='" + txtData.Text + "',horario='" + txtHora.Text + "',servicos='" + txtServicos.Text + "' where id = '" + txtId.Text + "'");
                CsFuncoes.Mensagem("Atualizado com sucesso", cbNome.Text + " Foi atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            carregarDados();
            
        }

        private void txtServicos_Leave(object sender, EventArgs e)
        {
            lblID.Text = txtId.Text;
            lblNome.Text = cbNome.Text;
            lblServicos.Text = txtServicos.Text;
            lblHora.Text = txtHora.Text;
            lblData.Text = txtData.Text;
            lblApelido.Text = txtApelido.Text;
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Isso sera permanente","Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CsBanco.ExecutarComandoSQL("update tb_horario set deletado='sim' where id = '" + txtId.Text + "'");
                    CsFuncoes.Mensagem("Agendamento foi excluido", cbNome.Text + " Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {

                }
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            carregarDados();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            txtApelido.Text = "";
            txtData.Text = "";
            txtHora.Text = "";
            txtId.Text = "";
            cbNome.Text = "";
            txtServicos.Text = "";
            lblApelido.Text = "";
            lblData.Text = "";
            lblHora.Text = "";
            lblID.Text = "";
            lblNome.Text = "";
            lblServicos.Text = "";
        }

        private void simToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //sim
            try
            {
                
                    CsBanco.ExecutarComandoSQL("update tb_horario set veio='sim' where id = '" + metroGrid1.CurrentRow.Cells[0].Value.ToString()+"'");
                    CsFuncoes.Mensagem("Presença confirmada","Pronto...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            carregarDados();
        }

        private void nãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //não
            try
            {
                if (MessageBox.Show(""+metroGrid1.CurrentRow.Cells[3].Value.ToString()+" não veio deseja remover da lista", "Removendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CsBanco.ExecutarComandoSQL("update tb_horario set deletado='sim' where id = '" + metroGrid1.CurrentRow.Cells[0].Value.ToString() + "'");
                    CsFuncoes.Mensagem("Agendamento foi removido", metroGrid1.CurrentRow.Cells[3].Value.ToString() + "Removendo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {

                }
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            carregarDados();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Isso sera permanente", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CsBanco.ExecutarComandoSQL("update tb_horario set deletado='sim' where id = '" + txtId.Text + "'");
                    CsFuncoes.Mensagem("Agendamento foi excluido", cbNome.Text + "Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {

                }
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            carregarDados();
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id,data,horario,nome,servicos,apelido
            txtId.Text = metroGrid1.CurrentRow.Cells[0].Value.ToString();
            txtData.Text = metroGrid1.CurrentRow.Cells[1].Value.ToString();
            txtHora.Text = metroGrid1.CurrentRow.Cells[2].Value.ToString();
            cbNome.Text = metroGrid1.CurrentRow.Cells[3].Value.ToString();
            txtServicos.Text = metroGrid1.CurrentRow.Cells[4].Value.ToString();
            txtApelido.Text = metroGrid1.CurrentRow.Cells[5].Value.ToString();
        }

        private void cbNome_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            CsBanco.buscarApelido(txtApelido, cbNome.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmCliente w = new frmCliente();
            w.ShowDialog();
            carregarclientes();
            
        }
    }
}
