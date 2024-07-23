/*//Inizializzazione
int min = 0;
int max = 100;
int maxTentativi = 10;
Random numeroCasuale = new Random();
char inserimento = 'o';
int tentativi;
//

Console.WriteLine($"Immagina un numero da {min} a {max}\n"); //Intro

int num = numeroCasuale.Next(min, max + 1); //Primo tentativo

for (tentativi = 1; tentativi <= maxTentativi; tentativi++)
{
    Console.Clear();
    Console.WriteLine($"Tentativo: {tentativi}/{maxTentativi} Tra: {min} e {max}\nForse è: {num}?\nc - Sì\n+ - Prova più alto\n- - Prova più basso");
    inserimento = Console.ReadKey(true).KeyChar;
    if (inserimento == '+') min = num++;
    else if (inserimento == '-') max = num--;
    else if (inserimento != 'c') { tentativi--; continue; }
    else if (inserimento == 'c') break;

    num = numeroCasuale.Next(min, max + 1);
}

if (inserimento == 'c') Console.WriteLine("Ho vinto!"); else { Console.WriteLine("Ho perso."); tentativi--; }
Console.WriteLine($"Tentativi effettuati: {tentativi}");
*/
/*
using Spectre.Console;

var grid = new Grid();
        
// Add columns 
grid.AddColumn();
grid.AddColumn();
grid.AddColumn();

// Add header row 
grid.AddRow(new string[]{"Header 1", "Header 2", "Header 3"});
grid.AddRow(new string[]{"Row 1", "Row 2", "Row 3"});

// Write to Console
AnsiConsole.Write(grid);
*/



int[] dadi = new int[5]; //Array di dadi
Random numeroCasuale = new Random();
//Lancio i 5 dadi
Console.Clear();
for (int i = 0; i < dadi.Length; i++)
{
    dadi[i] = numeroCasuale.Next(1, 7);
    Console.WriteLine($"{i + 1} = {dadi[i]}");
}
//Cambio dadi
Console.WriteLine("Quali dadi vuoi cambiare?");
string? cambiare = Console.ReadLine(); //Leggo una stringa che contiene i dadi da ri-lanciare
//Converto la stringa in una lista contenente i dadi da ri-lanciare e ri-lancio solo i dadi da ri-lanciare
for (int i = 0; i < cambiare!.Length; i++) dadi[Convert.ToInt32(cambiare.Substring(i, 1)) - 1] = numeroCasuale.Next(1, 7);
for (int i = 0; i < dadi.Length; i++) Console.WriteLine($"{i + 1} = {dadi[i]}"); //Ri-scrivo tutti i dadi
//
//Calcolo punteggio
int punteggioTotale = 0;
for (int i = 0; i < dadi.Length; i++) //Ciclo tutto l'array
{
    int punteggioParziale = 0;
    for (int j = 0; j < dadi.Length; j++) //Ri-ciclo l'array alla ricerca dei duplicati
        if (dadi[i] == dadi[j]) punteggioParziale++; //Se trovo un duplicato aumento il parziale
    if (punteggioParziale > punteggioTotale) punteggioTotale = punteggioParziale; //Se ho trovato un'occorrenza maggiore, aggiorno il punteggio
}
Console.WriteLine($"Punteggio: {punteggioTotale - 1}"); //Stampo il punteggio ridotto di 1



/*
using Spectre.Console;

using Spectre.Console.Rendering;

/////////////////////////////////////////////////////////////////
        // No colors
        /////////////////////////////////////////////////////////////////
        if (AnsiConsole.Profile.Capabilities.ColorSystem == ColorSystem.NoColors)
        {
            AnsiConsole.WriteLine("No colors are supported.");
            return;
        }

        /////////////////////////////////////////////////////////////////
        // 3-BIT
        /////////////////////////////////////////////////////////////////
        if (AnsiConsole.Profile.Supports(ColorSystem.Legacy))
        {
            AnsiConsole.ResetColors();
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule("[yellow bold underline]3-bit Colors[/]").RuleStyle("grey").LeftJustified());
            AnsiConsole.WriteLine();

            for (var i = 0; i < 8; i++)
            {
                AnsiConsole.Background = Color.FromInt32(i);
                AnsiConsole.Foreground = AnsiConsole.Background.GetInvertedColor();
                AnsiConsole.Write(string.Format(" {0,-9}", AnsiConsole.Background.ToString()));
                AnsiConsole.ResetColors();
                if ((i + 1) % 8 == 0)
                {
                    AnsiConsole.WriteLine();
                }
            }
        }

        /////////////////////////////////////////////////////////////////
        // 4-BIT
        /////////////////////////////////////////////////////////////////
        if (AnsiConsole.Profile.Supports(ColorSystem.Standard))
        {
            AnsiConsole.ResetColors();
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule("[yellow bold underline]4-bit Colors[/]").RuleStyle("grey").LeftJustified());
            AnsiConsole.WriteLine();

            for (var i = 0; i < 16; i++)
            {
                AnsiConsole.Background = Color.FromInt32(i);
                AnsiConsole.Foreground = AnsiConsole.Background.GetInvertedColor();
                AnsiConsole.Write(string.Format(" {0,-9}", AnsiConsole.Background.ToString()));
                AnsiConsole.ResetColors();
                if ((i + 1) % 8 == 0)
                {
                    AnsiConsole.WriteLine();
                }
            }
        }

        /////////////////////////////////////////////////////////////////
        // 8-BIT
        /////////////////////////////////////////////////////////////////
        if (AnsiConsole.Profile.Supports(ColorSystem.EightBit))
        {
            AnsiConsole.ResetColors();
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule("[yellow bold underline]8-bit Colors[/]").RuleStyle("grey").LeftJustified());
            AnsiConsole.WriteLine();

            for (var i = 0; i < 16; i++)
            {
                for (var j = 0; j < 16; j++)
                {
                    var number = i * 16 + j;
                    AnsiConsole.Background = Color.FromInt32(number);
                    AnsiConsole.Foreground = AnsiConsole.Background.GetInvertedColor();
                    AnsiConsole.Write(string.Format(" {0,-4}", number));
                    AnsiConsole.ResetColors();
                    if ((number + 1) % 16 == 0)
                    {
                        AnsiConsole.WriteLine();
                    }
                }
            }
        }

        /////////////////////////////////////////////////////////////////
        // 24-BIT
        /////////////////////////////////////////////////////////////////
        if (AnsiConsole.Profile.Supports(ColorSystem.TrueColor))
        {
            AnsiConsole.ResetColors();
            AnsiConsole.WriteLine();
            AnsiConsole.Write(new Rule("[yellow bold underline]24-bit Colors[/]").RuleStyle("grey").LeftJustified());
            AnsiConsole.WriteLine();

            AnsiConsole.Write(new ColorBox(width: 80, height: 15));
        }

        public sealed class ColorBox : Renderable
{
    private readonly int _height;
    private int? _width;

    public ColorBox(int height)
    {
        _height = height;
    }

    public ColorBox(int width, int height)
        : this(height)
    {
        _width = width;
    }

    protected override Measurement Measure(RenderOptions options, int maxWidth)
    {
        return new Measurement(1, GetWidth(maxWidth));
    }

    protected override IEnumerable<Segment> Render(RenderOptions options, int maxWidth)
    {
        maxWidth = GetWidth(maxWidth);

        for (var y = 0; y < _height; y++)
        {
            for (var x = 0; x < maxWidth; x++)
            {
                var h = x / (float)maxWidth;
                var l = 0.1f + ((y / (float)_height) * 0.7f);
                var (r1, g1, b1) = ColorFromHSL(h, l, 1.0f);
                var (r2, g2, b2) = ColorFromHSL(h, l + (0.7f / 10), 1.0f);

                var background = new Color((byte)(r1 * 255), (byte)(g1 * 255), (byte)(b1 * 255));
                var foreground = new Color((byte)(r2 * 255), (byte)(g2 * 255), (byte)(b2 * 255));

                yield return new Segment("▄", new Style(foreground, background));
            }

            yield return Segment.LineBreak;
        }
    }

    private int GetWidth(int maxWidth)
    {
        var width = maxWidth;
        if (_width != null)
        {
            width = Math.Min(_width.Value, width);
        }

        return width;
    }

    private static (float, float, float) ColorFromHSL(double h, double l, double s)
    {
        double r = 0, g = 0, b = 0;
        if (l != 0)
        {
            if (s == 0)
            {
                r = g = b = l;
            }
            else
            {
                double temp2;
                if (l < 0.5)
                {
                    temp2 = l * (1.0 + s);
                }
                else
                {
                    temp2 = l + s - (l * s);
                }

                var temp1 = 2.0 * l - temp2;

                r = GetColorComponent(temp1, temp2, h + 1.0 / 3.0);
                g = GetColorComponent(temp1, temp2, h);
                b = GetColorComponent(temp1, temp2, h - 1.0 / 3.0);
            }
        }

        return ((float)r, (float)g, (float)b);

    }

    private static double GetColorComponent(double temp1, double temp2, double temp3)
    {
        if (temp3 < 0.0)
        {
            temp3 += 1.0;
        }
        else if (temp3 > 1.0)
        {
            temp3 -= 1.0;
        }

        if (temp3 < 1.0 / 6.0)
        {
            return temp1 + (temp2 - temp1) * 6.0 * temp3;
        }
        else if (temp3 < 0.5)
        {
            return temp2;
        }
        else if (temp3 < 2.0 / 3.0)
        {
            return temp1 + ((temp2 - temp1) * ((2.0 / 3.0) - temp3) * 6.0);
        }
        else
        {
            return temp1;
        }
    }
}
public static class ColorExtensions
{
    public static Color GetInvertedColor(this Color color)
    {
        return GetLuminance(color) < 140 ? Color.White : Color.Black;
    }

    private static float GetLuminance(this Color color)
    {
        return (float)((0.2126 * color.R) + (0.7152 * color.G) + (0.0722 * color.B));
    }
}*/