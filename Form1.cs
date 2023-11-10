namespace Cadastro_Usuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objUsuario = new Usuario();

                objUsuario.nome = TxtNome.Text;
                objUsuario.matricula = TxtMatricula.Text;
                objUsuario.endereco = TxtEndereco.Text;
                objUsuario.dataNasc = TxtDataNasc.Value;
                objUsuario.calculaIdade();

                MessageBox.Show("Aluno Cadastrado com Sucesso!!!\nNome: " +
                   objUsuario.nome +
                   "\nMatricula: " + objUsuario.matricula + "\nEndereço: " +
                   objUsuario.endereco + "\nData Nascimento: " +
                   objUsuario.dataNasc.ToString() + "\nIdade: " +
                   objUsuario.getIdade().ToString(), "Confirmação Cadastro",
                   MessageBoxButtons.OK);



            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO",
                    MessageBoxButtons.OK);
            }
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {

            try
            {
                Aluno objAluno = new Aluno();

                objAluno.nome = TxtNome.Text;
                objAluno.matricula = TxtMatricula.Text;
                objAluno.endereco = TxtEndereco.Text;
                objAluno.dataNasc = TxtDataNasc.Value;

                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc

                objAluno.calculaIdade();
                objAluno.turma = TxtTurma.Text;
                objAluno.nota1 = double.Parse(TxtNota1.Text);
                objAluno.nota2 = double.Parse(TxtNota2.Text);
                objAluno.calculaMedia();


                MessageBox.Show("Aluno Cadastrado com Sucesso!!!\nNome: " +
                    objAluno.nome +
                    "\nMatricula: " + objAluno.matricula + "\nEndereço: " +
                    objAluno.endereco + "\nData Nascimento: " +
                    objAluno.dataNasc.ToString() + "\nIdade: " +
                    objAluno.getIdade().ToString() +
                    "\nTurma: " + objAluno.turma +
                    "\nNota 1 " + objAluno.nota1.ToString() +
                    "\nNota 2 " + objAluno.nota2.ToString() +
                    "\nMédia: " + objAluno.retornaMedia().ToString() +
                    "\nO aluno está " + objAluno.verificaAprovacao(),


                    "Confirmação Cadastro",
                    MessageBoxButtons.OK);



            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO",
                    MessageBoxButtons.OK);
            }


        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {

            try
            {
                Professor objProfessor = new Professor();

                objProfessor.nome = TxtNome.Text;
                objProfessor.matricula = TxtMatricula.Text;
                objProfessor.endereco = TxtEndereco.Text;
                objProfessor.dataNasc = TxtDataNasc.Value;

                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc

                objProfessor.calculaIdade();
                objProfessor.cargaHoraria = int.Parse(TxtCargaHoraria.Text);
                objProfessor.setTipo();

                MessageBox.Show("Professor Cadastrado com Sucesso!!!\nNome: " +
                    objProfessor.nome +
                    "\nMatricula: " + objProfessor.matricula + "\nEndereço: " +
                    objProfessor.endereco + "\nData Nascimento: " +
                    objProfessor.dataNasc.ToString() + "\nIdade: " +
                    objProfessor.getIdade().ToString() +
                    "\nCargaHoraria: " + objProfessor.cargaHoraria.ToString() +
                    "\nTipo Professor: " + objProfessor.getTipo(),


                    "Confirmação Cadastro",
                    MessageBoxButtons.OK);



            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO",
                    MessageBoxButtons.OK);
            }


        }
    }

}