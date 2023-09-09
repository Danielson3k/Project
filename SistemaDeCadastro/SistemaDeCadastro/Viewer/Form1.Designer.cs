namespace SistemaDeCadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalvar = new Button();
            btnNovo = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lblBuscarId = new Label();
            textBox1 = new TextBox();
            txtId = new TextBox();
            txtEndereco = new TextBox();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            txtUf = new TextBox();
            txtNome = new TextBox();
            mskCep = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
            lblId = new Label();
            lblNome = new Label();
            lblEndereco = new Label();
            lblCep = new Label();
            lblBairro = new Label();
            lblCidade = new Label();
            lblUf = new Label();
            lblTelefone = new Label();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.BackgroundImage = Properties.Resources._7172879_floppy_disc_save_storage_disk_icon__1_;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(40, 15);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(20, 20);
            btnSalvar.TabIndex = 1;
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.BackgroundImage = Properties.Resources._314417_document_icon;
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatStyle = FlatStyle.Flat;
            btnNovo.Location = new Point(10, 12);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(24, 23);
            btnNovo.TabIndex = 0;
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources._4696642_bin_delete_garbage_remove_trash_icon;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(66, 13);
            button3.Name = "button3";
            button3.Size = new Size(23, 24);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources._1815573_cross_cancel_delete_icon__1_;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(95, 15);
            button4.Name = "button4";
            button4.Size = new Size(26, 23);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources._9004811_search_find_magnifier_zoom_icon__2_;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(299, 18);
            button5.Name = "button5";
            button5.Size = new Size(20, 20);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // lblBuscarId
            // 
            lblBuscarId.AutoSize = true;
            lblBuscarId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscarId.Location = new Point(127, 15);
            lblBuscarId.Name = "lblBuscarId";
            lblBuscarId.Size = new Size(114, 21);
            lblBuscarId.TabIndex = 6;
            lblBuscarId.Text = "Buscar por id :";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(238, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 23);
            textBox1.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(12, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 8;
            // 
            // txtEndereco
            // 
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(12, 121);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(639, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Location = new Point(118, 175);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(237, 23);
            txtBairro.TabIndex = 8;
            txtBairro.TextChanged += textBox3_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Location = new Point(361, 175);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(243, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtUf
            // 
            txtUf.BorderStyle = BorderStyle.FixedSingle;
            txtUf.Location = new Point(610, 174);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(41, 23);
            txtUf.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(95, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(556, 23);
            txtNome.TabIndex = 8;
            txtNome.TextChanged += textBox6_TextChanged;
            // 
            // mskCep
            // 
            mskCep.BorderStyle = BorderStyle.FixedSingle;
            mskCep.Location = new Point(12, 174);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(100, 23);
            mskCep.TabIndex = 9;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(12, 225);
            mskTelefone.Mask = "(99) 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(146, 23);
            mskTelefone.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblId.Location = new Point(10, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 11;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(94, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(42, 15);
            lblNome.TabIndex = 12;
            lblNome.Text = "NOME";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.Location = new Point(10, 103);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(66, 15);
            lblEndereco.TabIndex = 13;
            lblEndereco.Text = "ENDEREÇO";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCep.Location = new Point(10, 156);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(27, 15);
            lblCep.TabIndex = 14;
            lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBairro.Location = new Point(118, 156);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(49, 15);
            lblBairro.TabIndex = 15;
            lblBairro.Text = "BAIRRO";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCidade.Location = new Point(361, 156);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(50, 15);
            lblCidade.TabIndex = 16;
            lblCidade.Text = "CIDADE";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUf.Location = new Point(610, 156);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(21, 15);
            lblUf.TabIndex = 17;
            lblUf.Text = "UF";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(10, 207);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 15);
            lblTelefone.TabIndex = 18;
            lblTelefone.Text = "TELEFONE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 256);
            Controls.Add(lblTelefone);
            Controls.Add(lblUf);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblCep);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(mskTelefone);
            Controls.Add(mskCep);
            Controls.Add(txtUf);
            Controls.Add(txtCidade);
            Controls.Add(txtBairro);
            Controls.Add(txtEndereco);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(textBox1);
            Controls.Add(lblBuscarId);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnNovo);
            Controls.Add(btnSalvar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnNovo;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lblBuscarId;
        private TextBox textBox1;
        private TextBox txtId;
        private TextBox txtEndereco;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private TextBox txtUf;
        private TextBox txtNome;
        private MaskedTextBox mskCep;
        private MaskedTextBox mskTelefone;
        private Label lblId;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblCep;
        private Label lblBairro;
        private Label lblCidade;
        private Label lblUf;
        private Label lblTelefone;
    }
}