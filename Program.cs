using DesafioPOO.Models;
//Smartphone modelo Nokia
Smartphone Nokia = new Nokia(numero: "123456", modelo: "XXXXX2", imei: "9999999", memoria: 16);
Nokia.Ligar();
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Youtube");
Console.WriteLine("\n \n");

Smartphone NokiaSemNumero = new Nokia(modelo: "XXXXX3", imei: "8888888", memoria: 16);
NokiaSemNumero.Ligar();
NokiaSemNumero.ReceberLigacao();
NokiaSemNumero.InstalarAplicativo("whatsApp");
Console.WriteLine("\n \n");

//Smartphone modelo Iphone

Smartphone Iphone = new Iphone(numero: "654321", modelo: "Iphone Xr", imei: "111111111", memoria: 126);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");
Console.WriteLine("\n \n");

Smartphone IphoneSemNumero = new Iphone(modelo: "Iphone Xr pro", imei: "222222222", memoria: 256);
IphoneSemNumero.Ligar();
IphoneSemNumero.ReceberLigacao();
IphoneSemNumero.InstalarAplicativo("Telegram");
