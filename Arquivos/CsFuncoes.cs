using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Comercio
{
    static class CsFuncoes
    {
        #region MensagemERRO_PADRAO
        static public void MensagemERRO_PADRAO(Exception ex)
        {
            Mensagem(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        #region RemoverFormatacaoDinheiro
        static public string RemoverFormatacaoDinheiro(string str)
        {

            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "¹", "²", "³", "R", "r", "¬", "º", "¨", "\"", "'", "-", ":", "(", ")", "ª", "|", "\\\\", "°", "_", "@", "#", "!", "$", "%", "&", "*", ";", "/", "<", ">", "?", "[", "]", "{", "}", "=", "+", "§", "´", "`", "^", "~" };


            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                str = str.Replace(caracteresEspeciais[i], "");
            }

            /** Troca os caracteres especiais da string por " " **/
            /*   str = Regex.Replace(str, @"[^\w\.@-]", "",
                                   RegexOptions.None, TimeSpan.FromSeconds(1.5));
            */
            return str.Trim();
        }
        #endregion
        #region QuebraDeLinhaNoListBox
        static public void QuebraDeLinhaNoListBox(DataGridView dataGridView, ListBox listBox)
        {
            string[] items = Regex.Split(dataGridView.CurrentRow.Cells[2].Value.ToString().Replace(",", Environment.NewLine), "\n");

            listBox.Items.AddRange(items);


        }
        #endregion
        #region InserirNoBancoOListBox
        static public string InserirNoBancoOListBox(ListBox listbox)
        {
            string itens = "";
            foreach (var item in listbox.Items)
            {
                itens += item + ",";
            }
            itens = itens.Remove(itens.Length - 1).Trim();
            return itens.Trim();
        }
        #endregion
        #region Mensagem
        static public void Mensagem(string Mensagem, string titulo, MessageBoxButtons botao, MessageBoxIcon icone)
        {
            MessageBox.Show(Mensagem, titulo, botao, icone);
        }
        #endregion
        #region FuncaoNaoPodeZeroNoCampo
        static public string FuncaoNaoPodeZeroNoCampo(string insira_uma_string)
        {
            double n = double.Parse(insira_uma_string);
            if (n <= 0)
            {
                insira_uma_string = "0";
            }
            else
            {

            }
            return insira_uma_string;
        }
        #endregion
        #region FormatLocalizacao
        static public string FormatLocalizacao(string Localizacao)
        {
            //00.000.000-00
            string response = Localizacao.Trim();
            if (response.Length == 3)
            {
                response = response.Insert(1, "-");
                response = response.Insert(3, "-");
            }
            else if (response.Length == 4)
            {
                response = response.Insert(1, "-");
                response = response.Insert(4, "-");
            }
            return response;
        }
        #endregion
        #region FormatDATA
        static public string FormatDATA(string sender)
        {
            //15/04/1995
            string response = sender.Trim();
            if (response.Length == 8)
            {
                response = response.Insert(2, "/");
                response = response.Insert(5, "/");
            }
            return response;
        }
        #endregion
        #region FormatCPF
        static public string FormatCPF(string sender)
        {
            //000.000.000-00
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            else if (response.Length == 10)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            return response;
        }
        #endregion
        #region FormatRG
        static public string FormatRG(string sender)
        {
            //00.000.000-00
            string response = sender.Trim();
            if (response.Length == 10)
            {
                response = response.Insert(8, "-");
                response = response.Insert(5, ".");
                response = response.Insert(2, ".");
            }
            else if (response.Length == 9)
            {
                //00.000.000-0
                response = response.Insert(8, "-");
                response = response.Insert(5, ".");
                response = response.Insert(2, ".");
            }
            return response;
        }
        #endregion
        #region FormatCNPJ
        static public string FormatCNPJ(string sender)
        {
            //99.999.999/9999-99
            string response = sender.Trim();
            if (response.Length == 14)
            {
                response = response.Insert(12, "-");
                response = response.Insert(8, "/");
                response = response.Insert(5, ".");
                response = response.Insert(2, ".");
            }
            return response;
        }
        #endregion
        #region FormatCelular
        static public string FormatCelular(string sender)
        {
            //(19)9 9697-3079
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(7, "-");
                response = response.Insert(3, " ");
                response = response.Insert(2, ")");
                response = response.Insert(0, "(");
            }
            return response;
        }
        #endregion
        #region FormatValor
        static public string FormatValor(TextBox txtvalor)
        {

            txtvalor.Text = string.Format("{0:0,0.00}", txtvalor.Text);
            return txtvalor.Text;
        }
        #endregion
        #region FormatTelefoneFixo
        static public string FormatTelefoneFixo(string sender)
        {
            //(19)3476-5758
            string response = sender.Trim();
            if (response.Length == 10)
            {
                response = response.Insert(6, "-");
                response = response.Insert(2, ")");
                response = response.Insert(0, "(");
            }
            return response;
        }
        #endregion
        #region FormatCEP
        static public string FormatCEP(string sender)
        {
            //13387-582
            string response = sender.Trim();
            if (response.Length == 8)
            {
                response = response.Insert(5, "-");
            }
            return response;
        }
        #endregion
        #region FormatDinheiro
        static public void FormatDinheiro(TextBox txtValor)
        {
            try
            {
                double valor = double.Parse(txtValor.Text);
                txtValor.Text = valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #region BuscarCEP
        static public void BuscarCEP(TextBox txtCEP, TextBox txtNumeroCASA, TextBox txtEstado, TextBox txtCidade, TextBox txtBairro, TextBox txtEndereco)
        {
            txtCEP.Text = FormatCEP(txtCEP.Text);
            try
            {

                string xml = "https://viacep.com.br/ws/@/xml".Replace("@", txtCEP.Text);
                DataSet ds = new DataSet();
                ds.ReadXml(xml);
                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["localidade"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtEndereco.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtCEP.Text = ds.Tables[0].Rows[0]["cep"].ToString();
                txtNumeroCASA.Focus();
                txtNumeroCASA.Select();

            }
            catch (Exception)
            {
                try
                {
                    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@&formato=xml".Replace("@", txtCEP.Text);
                    DataSet ds = new DataSet();
                    ds.ReadXml(xml);
                    txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
                    txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                    txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                    txtEndereco.Text = ds.Tables[0].Rows[0]["tipo_logradouro"].ToString() + " " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                    txtCEP.Text = ds.Tables[0].Rows[0][8].ToString();

                }
                catch (Exception)
                {

                }
                Mensagem("CEP unico, inserir manualmente os outros campos", "CEP Unico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumeroCASA.Focus();
                txtNumeroCASA.Select();

            }
        }
        #endregion
        #region Limpar todos os textbox
        static public void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        #endregion

    }
}
