using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Tijolao", imei: "222222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone(numero: "10111213", modelo: "XD", imei: "333333333", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Genshin Impact");