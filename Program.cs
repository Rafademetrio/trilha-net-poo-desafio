using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone telefone1 = new Nokia(numero: "123465", modelo: "C23", IMEI: "00005", memoria: 512);
Smartphone telefone2 = new Iphone("56123","11","00008",1024);


telefone1.Ligar();
telefone1.InstalarAplicativo("whatsapp");


telefone2.Ligar();
telefone2.InstalarAplicativo("banco do brasil");