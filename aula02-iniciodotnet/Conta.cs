using System;
using System.Collections.Generic;

namespace aula02_iniciodotnet
{
    public class Conta
    {

        public Conta(Correntista correntista,
                     int numero,
                     decimal saldo)
        {
            this.Correntista = correntista;
            this.numero = numero;            
            this.saldo = saldo;

        }
        public int numero { get; private set; }        
        public decimal saldo { get; set; }
        
        public Correntista Correntista { get; set; }

        /// <summary>
        /// o que faz
        /// por que?
        /// 
        /// </summary>
        /// <param name="valor">informar de 100 para cima</param>
        public void Depositar(decimal valor)
        {
            this.saldo +=valor;
        }

        public void Sacar(decimal valor)
        {
            this.saldo -= valor;
        }


    }
}