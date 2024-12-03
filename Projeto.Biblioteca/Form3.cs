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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto.Biblioteca
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Listar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void button1_Adicionar_Click(object sender, EventArgs e, int NumeroMatricula, string Nome, string Endereco, int telefone, string Email)
        {
            string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Utente (NumeroMatricula, Nome, Endereco, Telefone, Email) VALUES (@NumeroMatricula, @Nome, @Endereco, @Telefone, @Email)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NumeroMatricula", NumeroMatricula);
                    command.Parameters.AddWithValue("@Nome", Nome);
                    command.Parameters.AddWithValue("@Endereco", Endereco);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Email", Email);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        Console.WriteLine("Utente registado com sucesso!");
                    else
                        Console.WriteLine("Erro ao registar o contato.");

                    Console.Write("Qualquer tecla para continuar ... ");
                    Console.ReadKey();
                }
            }
        }
    }
}

