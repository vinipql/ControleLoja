
namespace ControleLoja
{
    partial class CriarUser
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
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Lbl_SenhaConfirma = new System.Windows.Forms.Label();
            this.Lbl_Token = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmaSenha = new System.Windows.Forms.TextBox();
            this.Txt_Token = new System.Windows.Forms.TextBox();
            this.Txt_NomeEmpresa = new System.Windows.Forms.TextBox();
            this.Lbl_NomeEmpresa = new System.Windows.Forms.Label();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Lbl_Caminho = new System.Windows.Forms.Label();
            this.Txt_Caminho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(242, 228);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirmar.TabIndex = 0;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Location = new System.Drawing.Point(84, 16);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(43, 13);
            this.Lbl_UserName.TabIndex = 1;
            this.Lbl_UserName.Text = "Usuário";
            this.Lbl_UserName.Click += new System.EventHandler(this.Lbl_UserName_Click);
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(89, 42);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Senha.TabIndex = 2;
            this.Lbl_Senha.Text = "Senha";
            this.Lbl_Senha.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_SenhaConfirma
            // 
            this.Lbl_SenhaConfirma.AutoSize = true;
            this.Lbl_SenhaConfirma.Location = new System.Drawing.Point(38, 68);
            this.Lbl_SenhaConfirma.Name = "Lbl_SenhaConfirma";
            this.Lbl_SenhaConfirma.Size = new System.Drawing.Size(89, 13);
            this.Lbl_SenhaConfirma.TabIndex = 3;
            this.Lbl_SenhaConfirma.Text = "Confirme a senha";
            // 
            // Lbl_Token
            // 
            this.Lbl_Token.AutoSize = true;
            this.Lbl_Token.Location = new System.Drawing.Point(89, 154);
            this.Lbl_Token.Name = "Lbl_Token";
            this.Lbl_Token.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Token.TabIndex = 4;
            this.Lbl_Token.Text = "Token";
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(144, 16);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(100, 20);
            this.Txt_UserName.TabIndex = 5;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(144, 42);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(100, 20);
            this.Txt_Senha.TabIndex = 6;
            // 
            // Txt_ConfirmaSenha
            // 
            this.Txt_ConfirmaSenha.Location = new System.Drawing.Point(144, 68);
            this.Txt_ConfirmaSenha.Name = "Txt_ConfirmaSenha";
            this.Txt_ConfirmaSenha.PasswordChar = '*';
            this.Txt_ConfirmaSenha.Size = new System.Drawing.Size(100, 20);
            this.Txt_ConfirmaSenha.TabIndex = 7;
            // 
            // Txt_Token
            // 
            this.Txt_Token.Location = new System.Drawing.Point(144, 147);
            this.Txt_Token.Name = "Txt_Token";
            this.Txt_Token.Size = new System.Drawing.Size(100, 20);
            this.Txt_Token.TabIndex = 8;
            this.Txt_Token.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Txt_NomeEmpresa
            // 
            this.Txt_NomeEmpresa.Location = new System.Drawing.Point(144, 94);
            this.Txt_NomeEmpresa.Name = "Txt_NomeEmpresa";
            this.Txt_NomeEmpresa.Size = new System.Drawing.Size(100, 20);
            this.Txt_NomeEmpresa.TabIndex = 9;
            // 
            // Lbl_NomeEmpresa
            // 
            this.Lbl_NomeEmpresa.AutoSize = true;
            this.Lbl_NomeEmpresa.Location = new System.Drawing.Point(48, 94);
            this.Lbl_NomeEmpresa.Name = "Lbl_NomeEmpresa";
            this.Lbl_NomeEmpresa.Size = new System.Drawing.Size(79, 13);
            this.Lbl_NomeEmpresa.TabIndex = 10;
            this.Lbl_NomeEmpresa.Text = "Nome Empresa";
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(41, 228);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Voltar.TabIndex = 11;
            this.Btn_Voltar.Text = "Voltar";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Caminho
            // 
            this.Lbl_Caminho.AutoSize = true;
            this.Lbl_Caminho.Location = new System.Drawing.Point(79, 184);
            this.Lbl_Caminho.Name = "Lbl_Caminho";
            this.Lbl_Caminho.Size = new System.Drawing.Size(48, 13);
            this.Lbl_Caminho.TabIndex = 12;
            this.Lbl_Caminho.Text = "Caminho";
            // 
            // Txt_Caminho
            // 
            this.Txt_Caminho.Location = new System.Drawing.Point(144, 184);
            this.Txt_Caminho.Name = "Txt_Caminho";
            this.Txt_Caminho.Size = new System.Drawing.Size(197, 20);
            this.Txt_Caminho.TabIndex = 13;
            // 
            // CriarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 263);
            this.Controls.Add(this.Txt_Caminho);
            this.Controls.Add(this.Lbl_Caminho);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Lbl_NomeEmpresa);
            this.Controls.Add(this.Txt_NomeEmpresa);
            this.Controls.Add(this.Txt_Token);
            this.Controls.Add(this.Txt_ConfirmaSenha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_UserName);
            this.Controls.Add(this.Lbl_Token);
            this.Controls.Add(this.Lbl_SenhaConfirma);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_UserName);
            this.Controls.Add(this.Btn_Confirmar);
            this.Name = "CriarUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primeiro Acesso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label Lbl_SenhaConfirma;
        private System.Windows.Forms.Label Lbl_Token;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_ConfirmaSenha;
        private System.Windows.Forms.TextBox Txt_Token;
        private System.Windows.Forms.TextBox Txt_NomeEmpresa;
        private System.Windows.Forms.Label Lbl_NomeEmpresa;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.Label Lbl_Caminho;
        private System.Windows.Forms.TextBox Txt_Caminho;
    }
}