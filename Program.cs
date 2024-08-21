using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Modelo 1", "12121212", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("98765432", "Modelo 2", "232323", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");