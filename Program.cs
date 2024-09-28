using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");

Smartphone iphone = new Iphone(numero: "1234567",modelo: "Modelo 2", imei: "x12uh34", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");