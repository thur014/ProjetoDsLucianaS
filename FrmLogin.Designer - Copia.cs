
namespace ProjetoDsArthur
{
    partial class FrmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtloginusuario = new System.Windows.Forms.TextBox();
            this.txtsenhausuario = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDsArthur.Properties.Resources.Dark_Grey_and_White_Minimalist_Website_Register_Desktop_Prototype;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 439);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtloginusuario
            // 
            this.txtloginusuario.Location = new System.Drawing.Point(373, 182);
            this.txtloginusuario.Multiline = true;
            this.txtloginusuario.Name = "txtloginusuario";
            this.txtloginusuario.Size = new System.Drawing.Size(234, 20);
            this.txtloginusuario.TabIndex = 2;
            // 
            // txtsenhausuario
            // 
            this.txtsenhausuario.Location = new System.Drawing.Point(373, 247);
            this.txtsenhausuario.Multiline = true;
            this.txtsenhausuario.Name = "txtsenhausuario";
            this.txtsenhausuario.Size = new System.Drawing.Size(234, 20);
            this.txtsenhausuario.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(373, 310);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(251, 32);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 432);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtsenhausuario);
            this.Controls.Add(this.txtloginusuario);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtloginusuario;
        private System.Windows.Forms.TextBox txtsenhausuario;
        private System.Windows.Forms.Button btnlogin;
    }
}