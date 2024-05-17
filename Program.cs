using DesafioPOO.Models;

var myIphone = new Iphone("14 99999-9999", "15", "654321567984231", 256);
var myNokia = new Nokia("16 99999-9999", "LS-22", "6542313635874168", 128);

myIphone.Ligar();
myNokia.ReceberLigacao();

myIphone.InstalarAplicativo("Facetime");
myNokia.InstalarAplicativo("WhatsApp");