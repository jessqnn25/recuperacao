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
namespace recuperacao
{
    public partial class Form2 : Form
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd='';database=veterinario;");
       
        public Form2()
        {
            InitializeComponent();
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       public void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        public void limparTela()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";

        }
        public void button3_Click(object sender, EventArgs e)
        {
            limparTela();
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
           

            MySqlCommand comando = new MySqlCommand("insert into veterinaria(nome, crv, formacao)values(" +
                "'" + textBox1.Text + "','"
                +textBox2.Text+ "','"
                +comboBox1.Text+ "')", conexao);

            conexao.Open();
            comando.ExecuteReader();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}
