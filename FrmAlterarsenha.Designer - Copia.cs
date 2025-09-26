
namespace ProjetoDsArthur
{
    partial class FrmAlterarsenha
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSENHA = new System.Windows.Forms.TextBox();
            this.txtLOGIN = new System.Windows.Forms.TextBox();
            this.btnSAIR = new System.Windows.Forms.Button();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.NEWnome = new System.Windows.Forms.Label();
            this.newnome2 = new System.Windows.Forms.Label();
            this.lblALTERAR = new System.Windows.Forms.Label();
            this.chkVerSenha = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDsArthur.Properties.Resources.Dark_Grey_and_White_Minimalist_Website_Register_Desktop_Prototype__1_1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(867, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSENHA
            // 
            this.txtSENHA.Location = new System.Drawing.Point(889, 276);
            this.txtSENHA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSENHA.Name = "txtSENHA";
            this.txtSENHA.Size = new System.Drawing.Size(235, 22);
            this.txtSENHA.TabIndex = 1;
            this.txtSENHA.TextChanged += new System.EventHandler(this.LBLsenha_TextChanged);
            // 
            // txtLOGIN
            // 
            this.txtLOGIN.Location = new System.Drawing.Point(889, 142);
            this.txtLOGIN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLOGIN.Name = "txtLOGIN";
            this.txtLOGIN.Size = new System.Drawing.Size(235, 22);
            this.txtLOGIN.TabIndex = 2;
            this.txtLOGIN.TextChanged += new System.EventHandler(this.txtLOGIN_TextChanged);
            this.txtLOGIN.Leave += new System.EventHandler(this.txtLOGIN_Leave);
            // 
            // btnSAIR
            // 
            this.btnSAIR.Location = new System.Drawing.Point(871, 375);
            this.btnSAIR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSAIR.Name = "btnSAIR";
            this.btnSAIR.Size = new System.Drawing.Size(100, 41);
            this.btnSAIR.TabIndex = 3;
            this.btnSAIR.Text = "SAIR";
            this.btnSAIR.UseVisualStyleBackColor = true;
            this.btnSAIR.Click += new System.EventHandler(this.btnSAIR_Click);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Location = new System.Drawing.Point(1111, 375);
            this.btnALTERAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(107, 41);
            this.btnALTERAR.TabIndex = 4;
            this.btnALTERAR.Text = "ALTERAR";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.btnALTERAR.Leave += new System.EventHandler(this.btnALTERAR_Leave);
            // 
            // NEWnome
            // 
            this.NEWnome.AutoSize = true;
            this.NEWnome.Location = new System.Drawing.Point(900, 96);
            this.NEWnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NEWnome.Name = "NEWnome";
            this.NEWnome.Size = new System.Drawing.Size(51, 17);
            this.NEWnome.TabIndex = 6;
            this.NEWnome.Text = "LOGIN";
            // 
            // newnome2
            // 
            this.newnome2.AutoSize = true;
            this.newnome2.Location = new System.Drawing.Point(900, 222);
            this.newnome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newnome2.Name = "newnome2";
            this.newnome2.Size = new System.Drawing.Size(55, 17);
            this.newnome2.TabIndex = 7;
            this.newnome2.Text = "SENHA";
            // 
            // lblALTERAR
            // 
            this.lblALTERAR.AutoSize = true;
            this.lblALTERAR.Location = new System.Drawing.Point(929, 49);
            this.lblALTERAR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblALTERAR.Name = "lblALTERAR";
            this.lblALTERAR.Size = new System.Drawing.Size(211, 17);
            this.lblALTERAR.TabIndex = 8;
            this.lblALTERAR.Text = "ALTERAR SENHA DO USUARO";
            // 
            // chkVerSenha
            // 
            this.chkVerSenha.AutoSize = true;
            this.chkVerSenha.Location = new System.Drawing.Point(984, 325);
            this.chkVerSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkVerSenha.Name = "chkVerSenha";
            this.chkVerSenha.Size = new System.Drawing.Size(98, 21);
            this.chkVerSenha.TabIndex = 10;
            this.chkVerSenha.Text = "checkBox1";
            this.chkVerSenha.UseVisualStyleBackColor = true;
            this.chkVerSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1012, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // FrmAlterarsenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 503);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkVerSenha);
            this.Controls.Add(this.lblALTERAR);
            this.Controls.Add(this.newnome2);
            this.Controls.Add(this.NEWnome);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnSAIR);
            this.Controls.Add(this.txtLOGIN);
            this.Controls.Add(this.txtSENHA);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAlterarsenha";
            this.Text = "FrmAlterarsenha";
            this.Load += new System.EventHandler(this.FrmAlterarsenha_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmAlterarsenha_KeyUp);
            this.Leave += new System.EventHandler(this.btnALTERAR_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSENHA;
        private System.Windows.Forms.TextBox txtLOGIN;
        private System.Windows.Forms.Button btnSAIR;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.Label NEWnome;
        private System.Windows.Forms.Label newnome2;
        private System.Windows.Forms.Label lblALTERAR;
        private System.Windows.Forms.CheckBox chkVerSenha;
        private System.Windows.Forms.Label label1;
    }
}