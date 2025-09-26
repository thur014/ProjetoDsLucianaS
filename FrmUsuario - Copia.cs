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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnCadastrar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            btnCadastrar.Enabled = true;
            txtLogin.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost; database=bdlojavirtual;uid=root;pwd=''");
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conn;
            comando.CommandText = ("insert into usuario(login,senha) values (@login,@senha)");
            comando.Parameters.AddWithValue("@login", txtLogin.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);
            conn.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("usuario cadastrado com sucesso");

        }
    }
}
