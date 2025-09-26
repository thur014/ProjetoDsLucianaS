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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String login;
            MySqlDataReader reg = null;
            MySqlConnection conn = new MySqlConnection("server=localhost;database=bdhotel;uid=root;pwd=''");
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conn;

            comando.CommandText = "select * from usuario where login =@login and senha= @senha";
            comando.Parameters.AddWithValue("@login", txtloginusuario.Text);
            comando.Parameters.AddWithValue("@senha", txtsenhausuario.Text);
            conn.Open();
            reg = comando.ExecuteReader();
            if (reg.Read())
            {
                login = reg["login"].ToString();
                MessageBox.Show("Usuário logado");

                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
                txtloginusuario.Text = "";
                txtsenhausuario.Text = "";
                txtloginusuario.Focus();
            }
        }
    }
}
    

