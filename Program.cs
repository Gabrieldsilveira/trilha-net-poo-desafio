using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia:");
Nokia n1 = new Nokia(numero: "1", modelo: "Nokia1", imei: "123456789", memoria: 128);
n1.Ligar();
n1.InstalarAplicativo("WhatsApp");
n1.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone:");
Iphone p1 = new Iphone(numero: "2", modelo: "Iphone1", imei: "987654321", memoria: 256);
n1.Ligar();
n1.InstalarAplicativo("Instagram");
n1.ReceberLigacao();

