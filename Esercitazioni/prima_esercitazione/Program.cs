/*
Console.WriteLine("Hello, Ginevra!");
Console.Write("Hello, Ginevra!");
Console.WriteLine("Hello,Ginevra!");
Console.Write("inserisci il tuo nome\n");               //il carattere \n serve ad andare a capo
Console.Write("inserisci il tuo nome\t");               //il carattere \t serve per fare un tab
*/
//questo è un commento 

///questo è un commento per la documentazione delle classi

//il commento multilinea si fa così

/*
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
*/

//Console.WriteLine("premi un tasto per terminare...");
//Console.ReadKey();  //attende la pressione di un tasto da parte dell'utente

string nome = Console.ReadLine()!;                      //legge una stringa da tastiera e la memorizza nella variabile nome 
                                                        //il ! serve a non far apparire il warning CS8600
                                                        //string? nome = console.ReadLine();
Console.WriteLine(nome);                               //stampa a video il contenuto della variabile nome
Console.WriteLine("Hello," + nome + "!");               //stampa a video la stringa "Hello," con il contenuto della variabile nome
  //oppure
Console.WriteLine($"Hello, {nome}!");
string cognome = "Vallebona";
Console.WriteLine($"Hello, {nome} {cognome}!");