namespace Comercio
{
    partial class frmRelatorioAgendamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdAgendamentoHoje = new MetroFramework.Controls.MetroRadioButton();
            this.rdAgendamentoQueNaoVinheram = new MetroFramework.Controls.MetroRadioButton();
            this.rdAgendamentosConcluido = new MetroFramework.Controls.MetroRadioButton();
            this.rdAgendamentoAmanha = new MetroFramework.Controls.MetroRadioButton();
            this.rdAgendamentosAtivos = new MetroFramework.Controls.MetroRadioButton();
            this.rdAgendamentosExcluidos = new MetroFramework.Controls.MetroRadioButton();
            this.rdTodosAgendamento = new MetroFramework.Controls.MetroRadioButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdAgendamentoHoje);
            this.panel1.Controls.Add(this.rdAgendamentoQueNaoVinheram);
            this.panel1.Controls.Add(this.rdAgendamentosConcluido);
            this.panel1.Controls.Add(this.rdAgendamentoAmanha);
            this.panel1.Controls.Add(this.rdAgendamentosAtivos);
            this.panel1.Controls.Add(this.rdAgendamentosExcluidos);
            this.panel1.Controls.Add(this.rdTodosAgendamento);
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 77);
            this.panel1.TabIndex = 89;
            // 
            // rdAgendamentoHoje
            // 
            this.rdAgendamentoHoje.AutoSize = true;
            this.rdAgendamentoHoje.Location = new System.Drawing.Point(243, 53);
            this.rdAgendamentoHoje.Name = "rdAgendamentoHoje";
            this.rdAgendamentoHoje.Size = new System.Drawing.Size(146, 15);
            this.rdAgendamentoHoje.TabIndex = 95;
            this.rdAgendamentoHoje.Text = "Agendamentos de hoje";
            this.rdAgendamentoHoje.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAgendamentoHoje.UseSelectable = true;
            // 
            // rdAgendamentoQueNaoVinheram
            // 
            this.rdAgendamentoQueNaoVinheram.AutoSize = true;
            this.rdAgendamentoQueNaoVinheram.Location = new System.Drawing.Point(3, 53);
            this.rdAgendamentoQueNaoVinheram.Name = "rdAgendamentoQueNaoVinheram";
            this.rdAgendamentoQueNaoVinheram.Size = new System.Drawing.Size(234, 15);
            this.rdAgendamentoQueNaoVinheram.TabIndex = 94;
            this.rdAgendamentoQueNaoVinheram.Text = "Cliente que agendou e não compareceu";
            this.rdAgendamentoQueNaoVinheram.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAgendamentoQueNaoVinheram.UseSelectable = true;
            // 
            // rdAgendamentosConcluido
            // 
            this.rdAgendamentosConcluido.AutoSize = true;
            this.rdAgendamentosConcluido.Location = new System.Drawing.Point(452, 32);
            this.rdAgendamentosConcluido.Name = "rdAgendamentosConcluido";
            this.rdAgendamentosConcluido.Size = new System.Drawing.Size(196, 15);
            this.rdAgendamentosConcluido.TabIndex = 93;
            this.rdAgendamentosConcluido.Text = "Agendamentos concluidos 100%";
            this.rdAgendamentosConcluido.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAgendamentosConcluido.UseSelectable = true;
            // 
            // rdAgendamentoAmanha
            // 
            this.rdAgendamentoAmanha.AutoSize = true;
            this.rdAgendamentoAmanha.Location = new System.Drawing.Point(395, 53);
            this.rdAgendamentoAmanha.Name = "rdAgendamentoAmanha";
            this.rdAgendamentoAmanha.Size = new System.Drawing.Size(166, 15);
            this.rdAgendamentoAmanha.TabIndex = 92;
            this.rdAgendamentoAmanha.Text = "Agendamentos de amanhã";
            this.rdAgendamentoAmanha.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAgendamentoAmanha.UseSelectable = true;
            // 
            // rdAgendamentosAtivos
            // 
            this.rdAgendamentosAtivos.AutoSize = true;
            this.rdAgendamentosAtivos.Location = new System.Drawing.Point(145, 32);
            this.rdAgendamentosAtivos.Name = "rdAgendamentosAtivos";
            this.rdAgendamentosAtivos.Size = new System.Drawing.Size(138, 15);
            this.rdAgendamentosAtivos.TabIndex = 91;
            this.rdAgendamentosAtivos.Text = "Agendamentos ativos";
            this.rdAgendamentosAtivos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAgendamentosAtivos.UseSelectable = true;
            // 
            // rdAgendamentosExcluidos
            // 
            this.rdAgendamentosExcluidos.AutoSize = true;
            this.rdAgendamentosExcluidos.Location = new System.Drawing.Point(289, 32);
            this.rdAgendamentosExcluidos.Name = "rdAgendamentosExcluidos";
            this.rdAgendamentosExcluidos.Size = new System.Drawing.Size(157, 15);
            this.rdAgendamentosExcluidos.TabIndex = 90;
            this.rdAgendamentosExcluidos.Text = "Agendamentos excluidos";
            this.rdAgendamentosExcluidos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdAgendamentosExcluidos.UseSelectable = true;
            // 
            // rdTodosAgendamento
            // 
            this.rdTodosAgendamento.AutoSize = true;
            this.rdTodosAgendamento.Location = new System.Drawing.Point(3, 32);
            this.rdTodosAgendamento.Name = "rdTodosAgendamento";
            this.rdTodosAgendamento.Size = new System.Drawing.Size(136, 15);
            this.rdTodosAgendamento.TabIndex = 89;
            this.rdTodosAgendamento.Text = "Todos agendamentos";
            this.rdTodosAgendamento.Theme = MetroFramework.MetroThemeStyle.Light;
            this.rdTodosAgendamento.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(792, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 312);
            this.panel2.TabIndex = 90;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(798, 312);
            this.metroGrid1.TabIndex = 91;
            // 
            // frmRelatorioAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRelatorioAgendamento";
            this.Padding = new System.Windows.Forms.Padding(1, 60, 1, 1);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Relatorio agendamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroRadioButton rdAgendamentoHoje;
        private MetroFramework.Controls.MetroRadioButton rdAgendamentoQueNaoVinheram;
        private MetroFramework.Controls.MetroRadioButton rdAgendamentosConcluido;
        private MetroFramework.Controls.MetroRadioButton rdAgendamentoAmanha;
        private MetroFramework.Controls.MetroRadioButton rdAgendamentosAtivos;
        private MetroFramework.Controls.MetroRadioButton rdAgendamentosExcluidos;
        private MetroFramework.Controls.MetroRadioButton rdTodosAgendamento;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}