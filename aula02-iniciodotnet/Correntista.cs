using System.Collections.Generic;

namespace aula02_iniciodotnet
{
    public class Correntista
    {
        public Correntista(int codigo, string nome, string cPF)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.CPF = cPF;

        }
        public int codigo { get; set; }
        public string nome { get; set; }
        public string CPF { get; set; }

        public List<Conta> Contas { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}