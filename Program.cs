//Range
int min = 0;
int max = 100;
//

Console.WriteLine($"Immagina un numero da {min} a {max}\n"); //Intro

//Inizializzazione
char inserimento = 'o';
int num = 50;
//

while(inserimento != 's') //Esce con 's'
{
    Console.WriteLine($"Forse è: {num}?\ns - Sì\na - Prova più alto\nb - Prova più basso");
    inserimento = Console.ReadKey(true).KeyChar;
    Console.Clear();
    if (inserimento == 'a') min = num;
    else if (inserimento == 'b') max = num;
    else if (inserimento != 's') continue;
    num = ((max-min)/2)+min;
}
Console.WriteLine(":-D");