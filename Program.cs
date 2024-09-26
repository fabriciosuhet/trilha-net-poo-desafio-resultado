using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Telefone Nokia");

Nokia n = new(numero: "123456", modelo: "modelo 1", imei: "1234", memoria: 64);
n.Ligar();
n.InstalarAplicativo("zapzap");
System.Console.WriteLine("\n");

System.Console.WriteLine("Telefone Iphone: ");
Iphone i = new(numero: "654321", modelo: "16 pro max", imei: "4321", memoria: 128);
i.ReceberLigacao();
i.InstalarAplicativo("Spotify PREMIUM");


