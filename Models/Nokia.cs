namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public Nokia(string modelo, string imei, int memoria) : base( modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp}: baixando... ");
            Console.WriteLine($"{nomeApp}: baixando... ");
            Console.WriteLine($"{nomeApp}: instalado com sucesso! ");
        }
    }
}