using DesafioPOO.Models;

var meuIphone = new Iphone(numero: "31999999999", imei: "356303488900992", modelo: "15 Pro Max", memoria: 256);
var meuNokia = new Nokia(numero: "31995196795", imei: "353612655606601", modelo: "X30", memoria: 128);

meuIphone.Ligar();
meuNokia.Ligar();

meuIphone.ReceberLigacao();
meuNokia.ReceberLigacao();

meuIphone.InstalarAplicativo("iFood");
meuNokia.InstalarAplicativo("FreeFire");

