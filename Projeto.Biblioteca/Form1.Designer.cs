namespace Projeto.Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_Nome_Funcionario = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.button1_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem Vindo!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faça o seu Login!";
            // 
            // textBox1_Nome_Funcionario
            // 
            this.textBox1_Nome_Funcionario.Location = new System.Drawing.Point(284, 173);
            this.textBox1_Nome_Funcionario.Name = "textBox1_Nome_Funcionario";
            this.textBox1_Nome_Funcionario.Size = new System.Drawing.Size(287, 20);
            this.textBox1_Nome_Funcionario.TabIndex = 2;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(284, 227);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.Size = new System.Drawing.Size(287, 20);
            this.textBox2_password.TabIndex = 3;
            // 
            // button1_Login
            // 
            this.button1_Login.Location = new System.Drawing.Point(168, 310);
            this.button1_Login.Name = "button1_Login";
            this.button1_Login.Size = new System.Drawing.Size(403, 32);
            this.button1_Login.TabIndex = 4;
            this.button1_Login.Text = "Login";
            this.button1_Login.UseVisualStyleBackColor = true;
            this.button1_Login.Click += new System.EventHandler(this.button1_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome Funcionário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // button2_Sair
            // 
            this.button2_Sair.Location = new System.Drawing.Point(713, 404);
            this.button2_Sair.Name = "button2_Sair";
            this.button2_Sair.Size = new System.Drawing.Size(75, 23);
            this.button2_Sair.TabIndex = 7;
            this.button2_Sair.Text = "Sair";
            this.button2_Sair.UseVisualStyleBackColor = true;
            this.button2_Sair.Click += new System.EventHandler(this.button2_Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Sair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1_Login);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_Nome_Funcionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_Nome_Funcionario;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.Button button1_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2_Sair;
    }
}

