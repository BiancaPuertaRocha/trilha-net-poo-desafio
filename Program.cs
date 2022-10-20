using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "23244", modelo: "modelo 123", imei: "9788", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("youtube");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Iphone(numero: "09090", modelo: "modelo 3", imei: "12345", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("youtube");