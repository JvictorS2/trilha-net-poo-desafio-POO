namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){
        }
        public Iphone(string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Entrado no AppStore...");
            Console.WriteLine($"{nomeApp}: baixando... ");
            Console.WriteLine($"{nomeApp}: baixando... ");
            Console.WriteLine($"{nomeApp}: instalado com sucesso!");
            
        }
    }
}