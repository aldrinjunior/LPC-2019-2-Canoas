using System;

namespace aula02_iniciodotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Correntista objCorrentista = new Correntista(
                                12,
                                "Luciano",
                                "98989898");

            Conta objLuciano = 
                new Conta(
                        objCorrentista,
                        234234,                        
                        100);            

            w(objLuciano.Correntista.nome);
            
            w($"conta numero {objLuciano.numero} e o titular é o {objLuciano.titular}");
            w("pressione  uma tecla para fechar");

            r();

            objLuciano.Depositar(1000);
            w("o saldo atual é " + objLuciano.saldo);
            r();
            objLuciano.Sacar(100);
            w("o saldo atual é " + objLuciano.saldo);


            
        }

        static void w(string msg)
        {
            Console.Write(msg);
        }
        static void r()
        {
            Console.ReadLine();
        }
    }
}
