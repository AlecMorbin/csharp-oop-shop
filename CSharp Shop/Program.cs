using CSharp_Shop;

Prodotto carta = new Prodotto("Foglio","Carta per scrivere",3,0.23f);
Console.WriteLine( carta.ToString());

Prodotto macchinetta = new Prodotto("Macchinetta HOT WHEELS", "Giocattolo di una macchina con design fantastico", 10, 0.23f);
Prodotto latte = new Prodotto("Latte", "Bevanda al alto valore nutritivo, specialmente calcio", 2, 0.04f);

Console.WriteLine (latte.ToString());

Console.WriteLine (macchinetta.ToString());

Console.WriteLine(macchinetta.nomeEsteso());
