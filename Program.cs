using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "98760011", modelo: "Modelo 01", imei: "000000001", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "999004567", modelo: "Modelo X", imei: "000000012", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");