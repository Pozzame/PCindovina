/*//Range
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
    if (inserimento == 'a') min = num; else if (inserimento == 'b') max = num; else if (inserimento != 's') continue;
    num = ((max-min)/2)+min;
}
Console.WriteLine(":-D");*/




int[] dadi = new int[5];
Random rng = new Random();

//Lancio i 5 dadi
for (int i=0;i<dadi.Length;i++) 
{
    dadi[i]=rng.Next(1, 7);
    Console.WriteLine($"{i+1} = {dadi[i]}");
}
//

Console.WriteLine("Quali dadi vuoi cambiare?");
string? tenere = Console.ReadLine(); //Leggo una stringa che contiene i dadi da ri-lanciare
List<int> tenuti = new List<int>();
for (int i=0;i<tenere!.Length;i++) tenuti.Add(Convert.ToInt32(tenere.Substring(i, 1))); //Converto la stringa in una lista contenente i dadi da ri-lanciare
for (int i=0;i<tenuti.Count;i++) dadi[tenuti[i]-1]=rng.Next(1, 7); //Ri-lancio solo i dadi da ri-lanciare
for (int i=0;i<dadi.Length;i++) Console.WriteLine($"{i+1} = {dadi[i]}"); //Ri-scrivo tutti i dadi