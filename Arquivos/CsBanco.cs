using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using MetroFramework.Controls;
using System.Management;

namespace Comercio
{
    static class CsBanco
    {

        #region variaveis
        static private SQLiteConnection conexao = new SQLiteConnection(@"Data Source=salao.db;Version=3;New=False;Compress=true;");
        static private SQLiteCommand comando;
        static private SQLiteDataAdapter adapter;
        static private SQLiteCommandBuilder sqBuilder;
        static private DataSet DS = new DataSet();
        static private DataTable DT = new DataTable();
        #endregion
        #region ExecutarComandoSQL
        static public void ExecutarComandoSQL(string StringSQL)
        {
            try
            {
                conexao.Open();//abrir conexao
                comando = conexao.CreateCommand();//abro a conexao pra passar o comando
                comando.CommandText = StringSQL;//passo a string sql
                comando.ExecuteNonQuery();//executa o comando
                conexao.Close();//fecho a conexao
                //ConfigBanco.Mensagem("Processo concluido", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CarregaDados
        static public void CarregaDados(string stringSql, DataGridView nomeDataGrid)
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = null;

            try
            {
                conn = new SQLiteConnection(conexao);
                SQLiteDataAdapter da = new SQLiteDataAdapter(stringSql, conexao);
                da.Fill(dt);
                nomeDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
        #endregion
        #region BuscarCliente
        static public void BuscarCliente(MetroComboBox comboBox)
        {
            comboBox.Items.Clear();
            string sql = "select nome from tb_cliente where deletado ='não'";
            try
            {


                conexao.Open();//abrir conexao
                //comando.CommandText = sql;//passo a string sql
                SQLiteCommand createcomand = new SQLiteCommand("select nome from tb_cliente where deletado ='não'", conexao);

                SQLiteDataReader dr = createcomand.ExecuteReader();
                while (dr.Read())
                {
                    comboBox.Items.Add(dr["nome"].ToString());
                }
                conexao.Close();//fecho a conexao
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
        }
        static public void buscarApelido(MetroTextBox txtApelido, string apelido)
        {
            string sql = "select apelido from tb_cliente where nome ='"+apelido+"'";
            try
            {


                conexao.Open();//abrir conexao
                //comando.CommandText = sql;//passo a string sql
                SQLiteCommand createcomand = new SQLiteCommand(sql, conexao);

                SQLiteDataReader dr = createcomand.ExecuteReader();
                while (dr.Read())
                {
                    txtApelido.Text = dr["apelido"].ToString();
                }
                conexao.Close();//fecho a conexao
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
        }
        #endregion
        #region BuscarCliente
        static public string VerificarRegistro(string registro)
        {

            try
            {


                conexao.Open();//abrir conexao
                //comando.CommandText = sql;//passo a string sql
                SQLiteCommand createcomand = new SQLiteCommand("select regis from reg", conexao);

                SQLiteDataReader dr = createcomand.ExecuteReader();
                while (dr.Read())
                {
                    registro = dr["regis"].ToString();
                }
                conexao.Close();//fecho a conexao
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            return registro;
        }
        static public string PegarMac(string mac)
        {
            try
            {
                ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMOS.Get();
                string enderecoMAC = String.Empty;
                mac = enderecoMAC;
                foreach (ManagementObject objMO in objMOC)
                {
                    //retorna endereço MAC do primeiro cartão
                    if (enderecoMAC == String.Empty)
                    {
                        if (objMO["MacAddress"] != null)
                            enderecoMAC = objMO["MacAddress"].ToString();
                    }
                    objMO.Dispose();
                }
                enderecoMAC = enderecoMAC.Replace(":", "");
                return enderecoMAC;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        static public string VerificarMac(string mac)
        {

            try
            {


                conexao.Open();//abrir conexao
                //comando.CommandText = sql;//passo a string sql
                SQLiteCommand createcomand = new SQLiteCommand("select mac from reg", conexao);

                SQLiteDataReader dr = createcomand.ExecuteReader();
                while (dr.Read())
                {
                    mac = dr["mac"].ToString();
                }
                conexao.Close();//fecho a conexao
            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            return mac;
        }
        #endregion
        public static string PegarMac()
        {
            try
            {
                System.Management.ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection objMOC = objMOS.Get();
                string enderecoMAC = String.Empty;
                foreach (ManagementObject objMO in objMOC)
                {
                    //retorna endereço MAC do primeiro cartão
                    if (enderecoMAC == String.Empty)
                    {
                        if (objMO["MacAddress"] != null)
                            enderecoMAC = objMO["MacAddress"].ToString();
                    }
                    objMO.Dispose();
                }
                enderecoMAC = enderecoMAC.Replace(":", "");
                return enderecoMAC;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void teste(MetroLabel lblMensagem , ToolStripButton btnAgendamento, ToolStripButton btnCliente, ToolStripSplitButton btnRelatorio, ToolStripButton btnTeste)
        {
            int resultado = 0, dia = 0; string status = "";
            try
            {
                conexao.Open();//abrir conexao
                //comando.CommandText = sql;//passo a string sql
                SQLiteCommand createcomand = new SQLiteCommand("select ultimoDia as 'Resultado',status,dia from tb_versaoTeste;", conexao);
                SQLiteDataReader dr = createcomand.ExecuteReader();
                while (dr.Read())
                {
                    resultado = int.Parse(dr["Resultado"].ToString()) - DateTime.Now.Day;
                    status = dr["status"].ToString();
                    dia = int.Parse(dr["dia"].ToString());
                    //MessageBox.Show("Status: "+status +"\n Dia: "+dia.ToString()+"\n Resultado: "+resultado.ToString());
                }
                conexao.Close();//fecho a conexao
                if (resultado == 1 || resultado == 2 || resultado == 3 || resultado == 4 || resultado == 5 || resultado == 6 || resultado == 7 || resultado == 8) 
                {
                    lblMensagem.Text = "Restantam " + (resultado) + " dias";
                    btnAgendamento.Enabled = true;
                    btnRelatorio.Enabled = true;
                    btnCliente.Enabled = true;
                    lblMensagem.Visible = true;
                    btnTeste.Enabled = false;
                   // btnTeste.Visible = false;
                    //CsBanco.ExecutarComandoSQL("UPDATE tb_versaoTeste set status ='nao acabou' where id = '1';");
                }
                else if(status == "nao ativo" && dia == 0)
                {
                    btnTeste.Enabled = true;
                    btnTeste.Visible = true;
                    btnAgendamento.Enabled = false;
                    btnRelatorio.Enabled = false;
                    btnCliente.Enabled = false;
                    lblMensagem.Visible = false;
                    //lblMensagem.Text = "entrou aqui";
//                    MessageBox.Show("entrou aqui na versao de teste");

                }
                else 
                {
                    lblMensagem.Text = "Sua versão de teste acabou\nEntre encontado com o vendedor";
                    btnTeste.Enabled = true;// ativei aqui dia 18/12/202 pra poder testar a versao de teste
                    btnTeste.Visible = true;/// ativei aqui dia 18/12/2020
                    btnAgendamento.Enabled = false;
                    btnRelatorio.Enabled = false;
                    btnCliente.Enabled = false;
                    if(lblMensagem.Text == "Sua versão de teste acabou\nEntre encontado com o vendedor")
                    {
                        btnTeste.Enabled = false;
                        btnTeste.Visible = false;
                        //MessageBox.Show("entrou aqui");
                    }
                    
                    

                    if (status == "ativo")
                    {
                        lblMensagem.Text = "ativo";
                        lblMensagem.Visible = false;
                        btnTeste.Visible = false;
                        btnTeste.Enabled = false;
                        /*btnAgendamento.Enabled = true;
                        btnRelatorio.Enabled = true;
                        btnCliente.Enabled = true;
                        lblMensagem.Visible = true;
                        */
                        


                    }
                    
                    
                    
                    
                        
                    
                }

            }
            catch (Exception ex)
            {
                CsFuncoes.MensagemERRO_PADRAO(ex);
            }
            
        }


        
    }
}
