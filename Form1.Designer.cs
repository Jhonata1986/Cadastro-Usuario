namespace Cadastro_Usuario
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
            groupBox1 = new GroupBox();
            TxtEndereco = new TextBox();
            TxtMatricula = new TextBox();
            TxtNome = new TextBox();
            TxtDataNasc = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnAluno = new Button();
            TxtNota2 = new TextBox();
            TxtNota1 = new TextBox();
            TxtTurma = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            BtnProfessor = new Button();
            TxtCargaHoraria = new TextBox();
            label8 = new Label();
            BtnUsuario = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtEndereco);
            groupBox1.Controls.Add(TxtMatricula);
            groupBox1.Controls.Add(TxtNome);
            groupBox1.Controls.Add(TxtDataNasc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(31, 29);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(592, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuário";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(118, 176);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(436, 29);
            TxtEndereco.TabIndex = 7;
            // 
            // TxtMatricula
            // 
            TxtMatricula.Location = new Point(118, 81);
            TxtMatricula.Name = "TxtMatricula";
            TxtMatricula.Size = new Size(176, 29);
            TxtMatricula.TabIndex = 6;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(118, 34);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(436, 29);
            TxtNome.TabIndex = 5;
            // 
            // TxtDataNasc
            // 
            TxtDataNasc.Location = new Point(187, 125);
            TxtDataNasc.Name = "TxtDataNasc";
            TxtDataNasc.Size = new Size(367, 29);
            TxtDataNasc.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 183);
            label4.Name = "label4";
            label4.Size = new Size(93, 22);
            label4.TabIndex = 3;
            label4.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 132);
            label3.Name = "label3";
            label3.Size = new Size(156, 22);
            label3.TabIndex = 2;
            label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 88);
            label2.Name = "label2";
            label2.Size = new Size(96, 22);
            label2.TabIndex = 1;
            label2.Text = "Matrícula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 22);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnAluno);
            groupBox2.Controls.Add(TxtNota2);
            groupBox2.Controls.Add(TxtNota1);
            groupBox2.Controls.Add(TxtTurma);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(31, 329);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(294, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aluno";
            // 
            // BtnAluno
            // 
            BtnAluno.Location = new Point(95, 157);
            BtnAluno.Name = "BtnAluno";
            BtnAluno.Size = new Size(120, 34);
            BtnAluno.TabIndex = 11;
            BtnAluno.Text = "Cadastrar";
            BtnAluno.UseVisualStyleBackColor = true;
            BtnAluno.Click += BtnAluno_Click;
            // 
            // TxtNota2
            // 
            TxtNota2.Location = new Point(82, 112);
            TxtNota2.Name = "TxtNota2";
            TxtNota2.Size = new Size(176, 29);
            TxtNota2.TabIndex = 10;
            // 
            // TxtNota1
            // 
            TxtNota1.Location = new Point(82, 70);
            TxtNota1.Name = "TxtNota1";
            TxtNota1.Size = new Size(176, 29);
            TxtNota1.TabIndex = 9;
            // 
            // TxtTurma
            // 
            TxtTurma.Location = new Point(82, 29);
            TxtTurma.Name = "TxtTurma";
            TxtTurma.Size = new Size(176, 29);
            TxtTurma.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 119);
            label7.Name = "label7";
            label7.Size = new Size(70, 22);
            label7.TabIndex = 3;
            label7.Text = "Nota 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 77);
            label6.Name = "label6";
            label6.Size = new Size(70, 22);
            label6.TabIndex = 2;
            label6.Text = "Nota 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 37);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 1;
            label5.Text = "Turma:";
            label5.Click += label5_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnProfessor);
            groupBox3.Controls.Add(TxtCargaHoraria);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(361, 338);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(317, 199);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Professor";
            // 
            // BtnProfessor
            // 
            BtnProfessor.Location = new Point(104, 148);
            BtnProfessor.Name = "BtnProfessor";
            BtnProfessor.Size = new Size(120, 34);
            BtnProfessor.TabIndex = 12;
            BtnProfessor.Text = "Cadastrar";
            BtnProfessor.UseVisualStyleBackColor = true;
            BtnProfessor.Click += BtnProfessor_Click;
            // 
            // TxtCargaHoraria
            // 
            TxtCargaHoraria.Location = new Point(150, 61);
            TxtCargaHoraria.Name = "TxtCargaHoraria";
            TxtCargaHoraria.Size = new Size(136, 29);
            TxtCargaHoraria.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 68);
            label8.Name = "label8";
            label8.Size = new Size(137, 22);
            label8.TabIndex = 2;
            label8.Text = "Carga Horária:";
            // 
            // BtnUsuario
            // 
            BtnUsuario.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUsuario.Location = new Point(278, 273);
            BtnUsuario.Name = "BtnUsuario";
            BtnUsuario.Size = new Size(120, 34);
            BtnUsuario.TabIndex = 3;
            BtnUsuario.Text = "Cadastrar";
            BtnUsuario.UseVisualStyleBackColor = true;
            BtnUsuario.Click += BtnUsuario_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(722, 570);
            Controls.Add(BtnUsuario);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private TextBox TxtEndereco;
        private TextBox TxtMatricula;
        private TextBox TxtNome;
        private DateTimePicker TxtDataNasc;
        private Button BtnAluno;
        private TextBox TxtNota2;
        private TextBox TxtNota1;
        private TextBox TxtTurma;
        private Button BtnProfessor;
        private TextBox TxtCargaHoraria;
        private Button BtnUsuario;
    }
}