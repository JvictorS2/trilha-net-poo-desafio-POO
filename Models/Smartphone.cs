namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        //Construtor para caso a pessoa não possua chip no celular, caso raro .
        public Smartphone( string modelo, string imei, int memoria)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            if(Numero == null)
            {
                Console.WriteLine("Impossivel realizar ligação esse celular não possui um número(chip), somente ligação de emergência é permetida.");
            }
            else
            {
                Console.WriteLine("Ligando...");
            }
        }

        public void ReceberLigacao()
        {
            if(Numero == null)
            {
                Console.WriteLine("Impossivel receber ligação, este smartphone não possui número");
            }
            else
            {
                Console.WriteLine("Recebendo ligação...");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}