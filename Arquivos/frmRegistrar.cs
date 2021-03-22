using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Comercio
{
    public partial class frmRegistrar : MetroFramework.Forms.MetroForm
    {
        public frmRegistrar()
        {
            InitializeComponent();
            verificarRegistro();
            
        }
        public void verificarRegistro()
        {
            
            if (Properties.Settings.Default.verificador == 1)
            {
                btnRegistrarr.Enabled = false;
            }
            else
            {
                btnRegistrarr.Enabled = true;
            }
        }
        public static string PegarMac()
        {
            try
            {
                ManagementObjectSearcher objMOS = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration");
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
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //CsFuncoes.Mensagem("\nEntre em contato Whats 19 99697-3079\nRegistro \"ENVIADO\" com sucesso, entre em contato\nPara que possa ser ativado definivamente, pois do contrario\nOs dados não serão salvos","Aviso importante",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            
            CsBanco.ExecutarComandoSQL("update reg set regis='1',mac='"+ PegarMac() + "' where id =1");
            Properties.Settings.Default.registro = PegarMac();
            Properties.Settings.Default.verificador = 1;
            Properties.Settings.Default.Save();



        }
        
        private void metroButton2_Click(object sender, EventArgs e)
        {
            //verificar se esta registrado
            
            string mac = "", registro = "";
            registro = CsBanco.VerificarRegistro(registro);
            mac = CsBanco.VerificarMac(mac);
            if(registro == "0")
            {
                MessageBox.Show("Programa não registrado");
            }
            if(registro == "1" )
            {
                MessageBox.Show("Programa registrado");
            }
            


            MessageBox.Show("Registro: "+registro+"\nMac: "+mac+"");
        }
    }
}
