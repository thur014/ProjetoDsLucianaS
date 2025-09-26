
namespace ProjetoDsArthur
{
    partial class consultar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NOME = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtTell = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.Txtema = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(772, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(772, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(769, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "TELEFONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "ENDEREÇO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "CIDADE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "EMAIL";
            // 
            // NOME
            // 
            this.NOME.AutoSize = true;
            this.NOME.Location = new System.Drawing.Point(61, 36);
            this.NOME.Name = "NOME";
            this.NOME.Size = new System.Drawing.Size(39, 13);
            this.NOME.TabIndex = 78;
            this.NOME.Text = "NOME";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(311, 456);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(141, 33);
            this.btnexcluir.TabIndex = 77;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Blue;
            this.btnvoltar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvoltar.Location = new System.Drawing.Point(979, 466);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(111, 36);
            this.btnvoltar.TabIndex = 76;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.ForeColor = System.Drawing.Color.Red;
            this.txtConsulta.Location = new System.Drawing.Point(67, 399);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(385, 32);
            this.txtConsulta.TabIndex = 75;
            this.txtConsulta.Text = "Consulte nome";
            // 
            // txtTell
            // 
            this.txtTell.Location = new System.Drawing.Point(772, 73);
            this.txtTell.Mask = "(99) 00000-0000";
            this.txtTell.Name = "txtTell";
            this.txtTell.Size = new System.Drawing.Size(278, 20);
            this.txtTell.TabIndex = 74;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(772, 129);
            this.txtCPF.Mask = "000.000.000/00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(278, 20);
            this.txtCPF.TabIndex = 73;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(772, 182);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(278, 20);
            this.txtCep.TabIndex = 72;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(67, 456);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(141, 36);
            this.btnSalvar.TabIndex = 71;
            this.btnSalvar.Text = "Alterar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(64, 168);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(414, 34);
            this.txtCidade.TabIndex = 70;
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(64, 221);
            this.txtendereco.Multiline = true;
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(414, 36);
            this.txtendereco.TabIndex = 69;
            // 
            // Txtema
            // 
            this.Txtema.Location = new System.Drawing.Point(64, 112);
            this.Txtema.Multiline = true;
            this.Txtema.Name = "Txtema";
            this.Txtema.Size = new System.Drawing.Size(414, 37);
            this.Txtema.TabIndex = 68;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(64, 52);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(414, 38);
            this.txtname.TabIndex = 67;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 528);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1037, 107);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NOME);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.Txtema);
            this.Controls.Add(this.txtname);
            this.Name = "consultar";
            this.Text = "consultar";
            this.Load += new System.EventHandler(this.consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NOME;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.MaskedTextBox txtTell;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.TextBox Txtema;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}