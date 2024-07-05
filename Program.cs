//Range
int min = 0;
int max = 100;
//

Console.WriteLine($"Immagina un numero da {min} a {max}\n"); //Intro

//Inizializzazione
Random rng = new Random();
char inserimento = 'o';
int num = rng.Next(max+1); //primo tentativo
int tentativi;
//

    for (tentativi = 1; tentativi <= 5; tentativi++)
    {
        Console.Clear();
        Console.WriteLine("Tentativo: " + tentativi);
        Console.WriteLine($"Forse è: {num}?\nc - Sì\n+ - Prova più alto\n- - Prova più basso");
        inserimento = Console.ReadKey(true).KeyChar;
        if (inserimento == '+') min = num++; else if (inserimento == '-') max=num--; else if (inserimento != 'c') { tentativi--; continue;} else if (inserimento == 'c') break;
        num = rng.Next(min,max+1);//num = ((max - min) / 2) + min;
    }

if (inserimento=='c') Console.WriteLine("Ho vinto!"); else {Console.WriteLine("Ho perso."); tentativi--;}
Console.WriteLine($"Tentativi effettuati: {tentativi}");




/*
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
for (int i=0;i<dadi.Length;i++) Console.WriteLine($"{i+1} = {dadi[i]}"); //Ri-scrivo tutti i dadi*/