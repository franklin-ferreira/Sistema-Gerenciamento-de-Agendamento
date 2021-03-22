namespace Comercio
{
    partial class frmRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarr = new MetroFramework.Controls.MetroButton();
            this.txtRegistrar = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnRegistrarr
            // 
            this.btnRegistrarr.Location = new System.Drawing.Point(93, 91);
            this.btnRegistrarr.Name = "btnRegistrarr";
            this.btnRegistrarr.Size = new System.Drawing.Size(198, 23);
            this.btnRegistrarr.TabIndex = 0;
            this.btnRegistrarr.Text = "Registrar";
            this.btnRegistrarr.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRegistrarr.UseSelectable = true;
            this.btnRegistrarr.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtRegistrar
            // 
            // 
            // 
            // 
            this.txtRegistrar.CustomButton.Image = null;
            this.txtRegistrar.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.txtRegistrar.CustomButton.Name = "";
            this.txtRegistrar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRegistrar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegistrar.CustomButton.TabIndex = 1;
            this.txtRegistrar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegistrar.CustomButton.UseSelectable = true;
            this.txtRegistrar.CustomButton.Visible = false;
            this.txtRegistrar.Lines = new string[0];
            this.txtRegistrar.Location = new System.Drawing.Point(38, 133);
            this.txtRegistrar.MaxLength = 32767;
            this.txtRegistrar.Name = "txtRegistrar";
            this.txtRegistrar.PasswordChar = '\0';
            this.txtRegistrar.PromptText = "Insira a chave ...";
            this.txtRegistrar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegistrar.SelectedText = "";
            this.txtRegistrar.SelectionLength = 0;
            this.txtRegistrar.SelectionStart = 0;
            this.txtRegistrar.ShortcutsEnabled = true;
            this.txtRegistrar.Size = new System.Drawing.Size(326, 23);
            this.txtRegistrar.TabIndex = 1;
            this.txtRegistrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegistrar.UseSelectable = true;
            this.txtRegistrar.WaterMark = "Insira a chave ...";
            this.txtRegistrar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegistrar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(128, 162);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(98, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Buscar";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 202);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtRegistrar);
            this.Controls.Add(this.btnRegistrarr);
            this.MaximizeBox = false;
            this.Name = "frmRegistrar";
            this.Padding = new System.Windows.Forms.Padding(1, 60, 1, 1);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Registrar";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegistrarr;
        private MetroFramework.Controls.MetroTextBox txtRegistrar;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}