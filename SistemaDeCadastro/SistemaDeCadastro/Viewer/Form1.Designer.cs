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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            txtNome = new TextBox();
            mskCep = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(12, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(639, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(118, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 23);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(361, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(243, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(610, 174);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(41, 23);
            textBox5.TabIndex = 8;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 256);
            Controls.Add(mskTelefone);
            Controls.Add(mskCep);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox txtNome;
        private MaskedTextBox mskCep;
        private MaskedTextBox mskTelefone;
    }
}