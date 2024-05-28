using System.ComponentModel;
using System.Drawing;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "+55 21 97265-7562", modelo: "Nokia Flip", imei: "823748273872975", memoria: 32);
Nokia.Ligar();
Nokia.InstalarAplicativo("Tinder");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "+55 21 97364-7817", modelo: "Iphone 15 Pro Max", imei: "826738246296741", memoria: 512);
Iphone.Ligar();
Iphone.InstalarAplicativo("Badoo");