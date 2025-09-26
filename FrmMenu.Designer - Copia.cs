
namespace ProjetoDsArthur
{
    partial class FrmMenu
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnconsultarcliente = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btnalterarsenha = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(560, -1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(611, 51);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(114, 23);
            this.btncliente.TabIndex = 2;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnconsultarcliente
            // 
            this.btnconsultarcliente.Location = new System.Drawing.Point(611, 116);
            this.btnconsultarcliente.Name = "btnconsultarcliente";
            this.btnconsultarcliente.Size = new System.Drawing.Size(114, 23);
            this.btnconsultarcliente.TabIndex = 3;
            this.btnconsultarcliente.Text = "Consultar Cliente";
            this.btnconsultarcliente.UseVisualStyleBackColor = true;
            this.btnconsultarcliente.Click += new System.EventHandler(this.btnconsultarcliente_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(611, 197);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(114, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.Location = new System.Drawing.Point(611, 260);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(114, 23);
            this.btnusuario.TabIndex = 5;
            this.btnusuario.Text = "Usuario";
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btnalterarsenha
            // 
            this.btnalterarsenha.Location = new System.Drawing.Point(611, 329);
            this.btnalterarsenha.Name = "btnalterarsenha";
            this.btnalterarsenha.Size = new System.Drawing.Size(114, 23);
            this.btnalterarsenha.TabIndex = 6;
            this.btnalterarsenha.Text = "Alterar senha";
            this.btnalterarsenha.UseVisualStyleBackColor = true;
            this.btnalterarsenha.Click += new System.EventHandler(this.btnalterarsenha_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(611, 430);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(114, 23);
            this.btnsair.TabIndex = 7;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(760, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDsArthur.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 555);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnalterarsenha);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnconsultarcliente);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnconsultarcliente;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btnalterarsenha;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}