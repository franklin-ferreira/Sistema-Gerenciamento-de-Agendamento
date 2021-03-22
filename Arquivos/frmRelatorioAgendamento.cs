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
    public partial class frmRelatorioAgendamento : MetroFramework.Forms.MetroForm
    {
        public frmRelatorioAgendamento()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            if (rdAgendamentoAmanha.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario where data = '" + (DateTime.Now.Day+1)+"/"+DateTime.Now.Month+"/"+DateTime.Now.Year + "' and veio ='não' and deletado = 'não';", metroGrid1);
            }
            else if(rdAgendamentoHoje.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario where data = '" + (DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year) + "' and veio ='não' and deletado = 'não';", metroGrid1);
            }
            else if(rdAgendamentoQueNaoVinheram.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario where data <= '" + (DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year) + "' and veio ='não' and deletado = 'não';", metroGrid1);
            }
            else if(rdAgendamentosAtivos.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario where data >= '" + (DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year) + "' and veio ='não' and deletado = 'não';", metroGrid1);
            }
            else if(rdAgendamentosConcluido.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario where veio = 'sim' and deletado = 'não';", metroGrid1);
            }
            else if(rdAgendamentosExcluidos.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario where deletado = 'sim';", metroGrid1);
            }
            else if(rdTodosAgendamento.Checked == true)
            {
                CsBanco.CarregaDados("select id,data,horario,nome,servicos,apelido,veio from tb_horario;", metroGrid1);
            }

        }
    }
}
