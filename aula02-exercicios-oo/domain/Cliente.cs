namespace aula02_exercicios_oo.domain
{
    public class Cliente : Pessoa
    {
        public decimal renda { get; set; }
        public Cliente(int codigo, string nome,decimal renda):
            base(codigo,nome)
        {
            this.renda = renda;
        }
       
    }
}