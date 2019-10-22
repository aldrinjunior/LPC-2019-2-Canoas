namespace restaurante.domain
{
    public class Consumo
    {
        public int id { get; set; }
        public Restaurante restaurante { get; set; }
        public decimal valor { get; set; }
        public string data { get; set; }
        
    }
}