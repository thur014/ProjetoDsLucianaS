using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProjetoDsArthur
{
    public partial class FrmAlterarsenha : Form
    {
        public FrmAlterarsenha()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=bdlojavirtual;uid=root;pwd=''");
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conn;
            comando.CommandText = ("update usuario set senha=@senha where login=@login");
            comando.Parameters.AddWithValue("@login", txtLOGIN.Text);
            comando.Parameters.AddWithValue("@senha", txtSENHA.Text);
            conn.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("senha alterada com sucesso");

        }

        private void LBLsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnALTERAR_Leave(object sender, EventArgs e)
        {

        }

        private void txtLOGIN_Leave(object sender, EventArgs e)
        {
            String senha;
            MySqlDataReader reg = null;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=bdlojavirtual;uid=root;pwd=''");
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conn;

            comando.CommandText = "select * from usuario where login = @login ;";
            comando.Parameters.AddWithValue("@login", txtLOGIN.Text);


            conn.Open();
            reg = comando.ExecuteReader();

            if (reg.Read())
            {
                senha = reg["senha"].ToString();
                txtSENHA.Text = senha;
                txtSENHA.UseSystemPasswordChar = true;
            }
            else
            {
                MessageBox.Show("Usuário não Logado!");
                txtLOGIN.Text = " ";
                txtSENHA.Text = " ";
                txtLOGIN.Focus();
            }
        }

        private void btnSAIR_Click(object sender, EventArgs e)
        {

        }

        private void btnCRIAR_Click(object sender, EventArgs e)
        {

        }

        private void txtLOGIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FrmAlterarsenha_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FrmAlterarsenha_Load(object sender, EventArgs e)
        {

        }
    }
}
        