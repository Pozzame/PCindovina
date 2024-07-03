//Range
int min = 0;
int max = 100;
//

Console.WriteLine($"Immagina un numero da {min} a {max}\n"); //Intro

//Inizializzazione
char inserimento = 'o';
int num = TrovatoreBinario(min,max);
//

while(inserimento != 's') //Esce con 's'
{
    Console.Clear();
    Console.WriteLine($"Forse è: {num}?\ns - Sì\na - Prova più alto\nb - Prova più basso");
    inserimento = Console.ReadKey(true).KeyChar;
    if (inserimento == 'a')
    {
        min = num;
        num = TrovatoreBinario(min,max);
    } else if (inserimento == 'b')
    {
        max = num;
        num = TrovatoreBinario(min,max);
    }else if (inserimento != 's') Console.WriteLine("Non ho capito. Riprova");
}
Console.WriteLine(":-D");

int TrovatoreBinario(int min, int max)
{
   return ((max-min)/2)+min;
}