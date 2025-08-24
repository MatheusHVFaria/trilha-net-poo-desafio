using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia m34 = new Nokia("345289753", "M 34", "HDJDYSÇUMRNM-45H", 256);
Nokia f67 = new Nokia("416534582", "F 67", "SKUSOLFMGIDFHSKD", 128);

Iphone iphone15 = new Iphone("6309745434", "Iphone 15 Pro Max", "u775957943930", 128);
Iphone iphone16 = new Iphone("9765308742", "Iphone 16 Max", "805ue9ykej9o4u", 128);

m34.Ligar();
f67.Ligar();

m34.InstalarAplicativo("Google Maps");
f67.InstalarAplicativo("Google Docs");

m34.ReceberLigacao();
f67.ReceberLigacao();

iphone15.Ligar();
iphone16.Ligar();

iphone15.InstalarAplicativo("Instagram");
iphone16.InstalarAplicativo("WhattsApp");

iphone15.ReceberLigacao();
iphone16.ReceberLigacao();