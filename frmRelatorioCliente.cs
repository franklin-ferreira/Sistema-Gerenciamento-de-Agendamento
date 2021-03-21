using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class frmRelatorioCliente : MetroFramework.Forms.MetroForm
    {
        public frmRelatorioCliente()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if(rdClientesAtivos.Checked == true)
                {
                    CsBanco.CarregaDados("select nome,apelido,aniversario from tb_cliente where deletado ='não'",metroGrid1);
                }
                else if(rdClientesExcluidos.Checked == true)
                {
                    
                    CsBanco.CarregaDados("select nome,apelido,aniversario from tb_cliente where deletado ='sim'", metroGrid1);
                }
                else if(rdFazendoAniversario.Checked == true)
                {

                }
                else if(rdTodosClientes.Checked == true)
                {
                    CsBanco.CarregaDados("select nome,apelido,aniversario from tb_cliente", metroGrid1);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
