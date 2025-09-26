
namespace ProjetoDsArthur
{
    partial class Frmcliente
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
            this.btnCADASTRAR = new System.Windows.Forms.Button();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.btnVOLTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoDsArthur.Properties.Resources.Dark_Grey_and_White_Minimalist_Website_Register_Desktop_Prototype1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1058, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCADASTRAR
            // 
            this.btnCADASTRAR.Location = new System.Drawing.Point(894, 116);
            this.btnCADASTRAR.Name = "btnCADASTRAR";
            this.btnCADASTRAR.Size = new System.Drawing.Size(109, 36);
            this.btnCADASTRAR.TabIndex = 1;
            this.btnCADASTRAR.Text = "CADASTRAR";
            this.btnCADASTRAR.UseVisualStyleBackColor = true;
            this.btnCADASTRAR.Click += new System.EventHandler(this.btnCADASTRAR_Click);
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.Location = new System.Drawing.Point(894, 278);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(109, 36);
            this.btnCALCULAR.TabIndex = 2;
            this.btnCALCULAR.Text = "CALCULAR";
            this.btnCALCULAR.UseVisualStyleBackColor = true;
            // 
            // btnVOLTAR
            // 
            this.btnVOLTAR.Location = new System.Drawing.Point(894, 472);
            this.btnVOLTAR.Name = "btnVOLTAR";
            this.btnVOLTAR.Size = new System.Drawing.Size(109, 36);
            this.btnVOLTAR.TabIndex = 3;
            this.btnVOLTAR.Text = "VOLTAR";
            this.btnVOLTAR.UseVisualStyleBackColor = true;
            this.btnVOLTAR.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 694);
            this.Controls.Add(this.btnVOLTAR);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.btnCADASTRAR);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frmcliente";
            this.Text = "Frmcliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCADASTRAR;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Button btnVOLTAR;
    }
}