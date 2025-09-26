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
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void consultar_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=bdlojavirtual;uid=root;pwd=''");
            MySqlCommand comando = new MySqlCommand();

            comando.Connection = conn;
            comando.CommandText = ("update into cliente(cpf,nome,cidade,telefone,email,cep,endereco) values(@cpf,@nome,@cidade,@telefone,@email,@cep,@endereco)");
            comando.Parameters.AddWithValue("@nome", txtname.Text);
            comando.Parameters.AddWithValue("@cidade", txtCidade.Text);
            comando.Parameters.AddWithValue("@endereco", txtendereco.Text);
            comando.Parameters.AddWithValue("@telefone", txtTell.Text);
            comando.Parameters.AddWithValue("@email", Txtema.Text);
            comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
            comando.Parameters.AddWithValue("@cep", txtCep.Text);

            conn.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Conta alterada com Sucesso! ");

            txtname.Text = "";
            txtCidade.Text = "";
            txtTell.Text = "";
            Txtema.Text = "";
            txtCPF.Text = "";
            txtendereco.Text = "";
            txtCep.Text = "";
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();    
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deja excluir este registro? ", "Exclusão de dados", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection("server=localhost; database=bdlojavirtual; uid=root;pwd=' '");
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conn;
                comando.CommandText = "delete from cliente where cpf=@cpf";
                comando.Parameters.AddWithValue("@cpf", txtCPF.Text);
                conn.Open();
                comando.ExecuteNonQuery();
                txtname.Text = "";
                txtCidade.Text = "";
                txtTell.Text = "";
                Txtema.Text = "";
                txtCPF.Text = "";
                txtendereco.Text = "";
                txtCep.Text = "";


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCidade.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTell.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Txtema.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtCPF.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtendereco.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtCep.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
