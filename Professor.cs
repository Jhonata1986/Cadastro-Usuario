using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Usuario
{
    internal class Professor:Usuario
    {
        public int cargaHoraria { get; set; }aaa
        public string tipo { get; set; }


        public Professor()
        {
            this.cargaHoraria = 0;
            this.tipo = "";
        }

        //método set e get para o atributo cargaHoraria
      
        //método para atribuir valor ao tipo
        public void setTipo()
        {
            if (this.cargaHoraria >= 50)
            {
                this.tipo = "Dedicação Integral";
            }
            else
            {
                this.tipo = "Convidado";
            }
        }

        public string getTipo()
        {
            return this.tipo;
        }
    }
}
