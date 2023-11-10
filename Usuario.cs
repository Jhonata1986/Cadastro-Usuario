using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Usuario
{
    internal class Usuario
    {
        //declaração dos atributos
        public string nome { get; set; }
        public string matricula { get; set; }
        public DateTime dataNasc { get; set; }
        public string endereco { get; set; }   
        public int idade { get; set; }

        //método construtor para a classe
        public Usuario()
        {
            this.nome = "";
            this.matricula = "";
            this.dataNasc = DateTime.Today;
            this.endereco = "";
            this.idade = 0;
        }


        //métodos set e get
        //para os atributos: nome, matricula, endereço, dataNasc
      

        //método de funcionalidade
        public void calculaIdade()
        {
            this.idade = DateTime.Today.Year - dataNasc.Year;
        }

        //método getIdade
        public int getIdade()
        {
            return this.idade;
        }



    }

}
