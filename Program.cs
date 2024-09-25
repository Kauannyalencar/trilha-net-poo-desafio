using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia1 = new Nokia(numero:"123456", modelo:"Modelo 1", imei:"1111111", memoria:64);


Console.WriteLine("Smartphone Nokia:");
nokia1.Ligar();
nokia1.InstalarAplicativo("X");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero:"6547890", modelo:"Modelo 2", imei:"222222", memoria:124);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("League of legends");