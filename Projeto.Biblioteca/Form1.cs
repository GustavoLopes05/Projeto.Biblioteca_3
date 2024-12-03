using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto.Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Login_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";

            //verifica se o id existe
            string Nome = textBox1_Nome_Funcionario.Text;
            string Passwor_Funcionario = textBox2_password.Text;

            if (string.IsNullOrWhiteSpace(Nome))
            {
                MessageBox.Show("Por favor, insira seu número de funcionário.");
                return;
            }

            else if (string.IsNullOrWhiteSpace(Passwor_Funcionario))
            {
                MessageBox.Show("Por favor, insira sua password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Funcionarios WHERE Nome = @Nome AND  Passwor_Funcionario = @Passwor_Funcionario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", Nome);
                    command.Parameters.AddWithValue("@Passwor_Funcionario", Passwor_Funcionario);


                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        this.Hide();
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Número de funcionário ou password incorreta");
                    }


                }
            }
        }
        private void button2_Sair_Click(object sender, EventArgs e)
        {
          this.Close();
        }

    }
}
 