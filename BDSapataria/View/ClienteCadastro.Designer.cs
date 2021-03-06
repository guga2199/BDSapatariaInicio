﻿namespace BDSapataria.View
{
    partial class ClienteCadastro
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpfCliente = new System.Windows.Forms.Label();
            this.labelTelefoneCliente = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxFone = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 152);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(167, 25);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome completo:";
            // 
            // labelCpfCliente
            // 
            this.labelCpfCliente.AutoSize = true;
            this.labelCpfCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpfCliente.Location = new System.Drawing.Point(119, 198);
            this.labelCpfCliente.Name = "labelCpfCliente";
            this.labelCpfCliente.Size = new System.Drawing.Size(60, 25);
            this.labelCpfCliente.TabIndex = 1;
            this.labelCpfCliente.Text = "CPF:";
            // 
            // labelTelefoneCliente
            // 
            this.labelTelefoneCliente.AutoSize = true;
            this.labelTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefoneCliente.Location = new System.Drawing.Point(77, 241);
            this.labelTelefoneCliente.Name = "labelTelefoneCliente";
            this.labelTelefoneCliente.Size = new System.Drawing.Size(102, 25);
            this.labelTelefoneCliente.TabIndex = 2;
            this.labelTelefoneCliente.Text = "Telefone:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndereco.Location = new System.Drawing.Point(69, 291);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(110, 25);
            this.labelEndereco.TabIndex = 3;
            this.labelEndereco.Text = "Endereço:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(185, 157);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(190, 20);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(185, 204);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(190, 20);
            this.textBoxCpf.TabIndex = 5;
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(185, 247);
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(190, 20);
            this.textBoxFone.TabIndex = 6;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(185, 297);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(190, 20);
            this.textBoxEndereco.TabIndex = 7;
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(124, 366);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(126, 23);
            this.buttonCadastrarCliente.TabIndex = 8;
            this.buttonCadastrarCliente.Text = "Confirmar cadastro";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.buttonCadastrarCliente_Click);
            // 
            // ClienteCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 461);
            this.Controls.Add(this.buttonCadastrarCliente);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelTelefoneCliente);
            this.Controls.Add(this.labelCpfCliente);
            this.Controls.Add(this.labelNome);
            this.Name = "ClienteCadastro";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.ClienteCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCpfCliente;
        private System.Windows.Forms.Label labelTelefoneCliente;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxFone;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Button buttonCadastrarCliente;
    }
}