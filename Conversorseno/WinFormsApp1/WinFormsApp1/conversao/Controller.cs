using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.SenoCosTang
{
    public class Controller : AbsProp
    {
        public  Controller(string numero)
        {
            this.numero = numero;
        }


        public override void Executar()
        {

            Validacao val = new Validacao(this.numero);
            val.Executar();
            this.mensagem = val.mensagem;
            this.valor = val.valor;

            if (mensagem != "erro")
            {
                Calcular cal = new Calcular(this.valor);


                cal.Executar();
                this.tang = cal.tang;


                this.seno = cal.seno;
                this.cons = cal.cons;
                
            }

             
        }

    }
}
