using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Usuario
{
    internal class Aluno:Usuario
    {
        public string turma { get; set; }
        public double nota1 { get; set; }

        public double nota2 {get; set; }

        public double media { get; set; }

        public Aluno()
        {
            this.turma = "";
            this.nota1 = 0;
            this.nota2 = 0;
            this.media = 0;
        }

        //método set e get para turma,nota1 e nota2
       

        //método para calcular a media
        public void calculaMedia()
        {
            this.media = (this.nota1 + this.nota2) / 2;
        }
        //método para retornar a média
        public double retornaMedia()
        {
            return this.media;
        }
        //método para verificar a aprovação
        public string verificaAprovacao()
        {
            if (this.media >= 7)
                return "Aprovado";
            else
                return "Reprovado";
        }
    }
}
