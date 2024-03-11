// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;

class Program {
    public static void Main(string[] args)
    {
       
        int[] tab1 = { 4, 3, 3, 4, 5, 2 };
        Console.WriteLine(AVGgrades(tab1));
    }

static int AVGgrades(int[] ocenyTab){
    int srednia;
    int suma = 0;
    int liczba = 0;
    foreach (var n in ocenyTab)
    {
        suma += n;
        liczba++;
    }

    srednia = suma / (liczba);
    return srednia;
        }
}