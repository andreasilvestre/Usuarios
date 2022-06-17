namespace Usuarios
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
            this.label_NomeCompleto = new System.Windows.Forms.Label();
            this.textBox_NomeCompleto = new System.Windows.Forms.TextBox();
            this.button_Conectar = new System.Windows.Forms.Button();
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.button_Remover = new System.Windows.Forms.Button();
            this.listView_Usuarios = new System.Windows.Forms.ListView();
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_NomeCompleto
            // 
            this.label_NomeCompleto.AutoSize = true;
            this.label_NomeCompleto.Location = new System.Drawing.Point(23, 18);
            this.label_NomeCompleto.Name = "label_NomeCompleto";
            this.label_NomeCompleto.Size = new System.Drawing.Size(84, 13);
            this.label_NomeCompleto.TabIndex = 0;
            this.label_NomeCompleto.Text = "Nome completo:";
            // 
            // textBox_NomeCompleto
            // 
            this.textBox_NomeCompleto.Location = new System.Drawing.Point(113, 15);
            this.textBox_NomeCompleto.Name = "textBox_NomeCompleto";
            this.textBox_NomeCompleto.Size = new System.Drawing.Size(270, 20);
            this.textBox_NomeCompleto.TabIndex = 0;
            this.textBox_NomeCompleto.TextChanged += new System.EventHandler(this.textBox_NomeCompleto_TextChanged);
            // 
            // button_Conectar
            // 
            this.button_Conectar.Location = new System.Drawing.Point(79, 48);
            this.button_Conectar.Name = "button_Conectar";
            this.button_Conectar.Size = new System.Drawing.Size(111, 38);
            this.button_Conectar.TabIndex = 2;
            this.button_Conectar.Text = "Conectar";
            this.button_Conectar.UseVisualStyleBackColor = true;
            this.button_Conectar.Click += new System.EventHandler(this.button_Conectar_Click);
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(196, 47);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(99, 39);
            this.button_Adicionar.TabIndex = 1;
            this.button_Adicionar.Text = "Adicionar";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(301, 47);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(86, 38);
            this.button_Remover.TabIndex = 2;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            this.button_Remover.Click += new System.EventHandler(this.button_Remover_Click);
            // 
            // listView_Usuarios
            // 
            this.listView_Usuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUsuario,
            this.NomeCompleto,
            this.Email});
            this.listView_Usuarios.HideSelection = false;
            this.listView_Usuarios.Location = new System.Drawing.Point(26, 124);
            this.listView_Usuarios.Name = "listView_Usuarios";
            this.listView_Usuarios.Size = new System.Drawing.Size(492, 314);
            this.listView_Usuarios.TabIndex = 5;
            this.listView_Usuarios.UseCompatibleStateImageBehavior = false;
            this.listView_Usuarios.View = System.Windows.Forms.View.Details;
            // 
            // idUsuario
            // 
            this.idUsuario.Text = "IdUsuario";
            this.idUsuario.Width = 40;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Text = "Nome completo";
            this.NomeCompleto.Width = 100;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Usuários cadastrados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Usuarios);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.button_Adicionar);
            this.Controls.Add(this.button_Conectar);
            this.Controls.Add(this.textBox_NomeCompleto);
            this.Controls.Add(this.label_NomeCompleto);
            this.Name = "Form1";
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NomeCompleto;
        private System.Windows.Forms.TextBox textBox_NomeCompleto;
        private System.Windows.Forms.Button button_Conectar;
        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.ListView listView_Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader NomeCompleto;
        private System.Windows.Forms.ColumnHeader Email;
    }
}

