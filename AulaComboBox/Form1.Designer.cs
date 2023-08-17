namespace AulaComboBox
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
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPosicao = new System.Windows.Forms.TextBox();
            this.tbTextoSelecionado = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimparLista = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um texto:";
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(110, 44);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(200, 20);
            this.tbTexto.TabIndex = 1;
            this.tbTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTexto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estilo Dropdown List:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Posição na Lista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Texto Selecionado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total de Itens:";
            // 
            // tbPosicao
            // 
            this.tbPosicao.Location = new System.Drawing.Point(127, 311);
            this.tbPosicao.Name = "tbPosicao";
            this.tbPosicao.ReadOnly = true;
            this.tbPosicao.Size = new System.Drawing.Size(100, 20);
            this.tbPosicao.TabIndex = 3;
            // 
            // tbTextoSelecionado
            // 
            this.tbTextoSelecionado.Location = new System.Drawing.Point(141, 367);
            this.tbTextoSelecionado.Name = "tbTextoSelecionado";
            this.tbTextoSelecionado.ReadOnly = true;
            this.tbTextoSelecionado.Size = new System.Drawing.Size(100, 20);
            this.tbTextoSelecionado.TabIndex = 3;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(127, 421);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 3;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(212, 165);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 118);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 5;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(127, 118);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 6;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btLimparLista
            // 
            this.btLimparLista.Location = new System.Drawing.Point(55, 165);
            this.btLimparLista.Name = "btLimparLista";
            this.btLimparLista.Size = new System.Drawing.Size(117, 23);
            this.btLimparLista.TabIndex = 7;
            this.btLimparLista.Text = "Limpar Toda a Lista";
            this.btLimparLista.UseVisualStyleBackColor = true;
            this.btLimparLista.Click += new System.EventHandler(this.btLimparLista_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(252, 118);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 8;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 473);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btLimparLista);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbTextoSelecionado);
            this.Controls.Add(this.tbPosicao);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Combo Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPosicao;
        private System.Windows.Forms.TextBox tbTextoSelecionado;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimparLista;
        private System.Windows.Forms.Button btLimpar;
    }
}

