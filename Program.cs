using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("99845588", "nokia a70", "4555554444", 32);
nokia.Ligar();
nokia.InstalarAplicativo("telegram");

Console.WriteLine("\n");

Iphone iphone = new Iphone("5558488", "iphone 14", "11115544858", 64);
iphone.Ligar();
iphone.InstalarAplicativo("instagram");
iphone.ReceberLigacao();
