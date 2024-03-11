// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Dataflow;

class Program {
    public static void Main(string[] args)
    {
       
        int[] tab1 = { 1, 2, 3, 4, 5, 6 };
        
        int size = tab1.Length;
        foreach (int num in tab1)
        {
            Console.WriteLine(num); 
        }

    

static double AVGgrades(int[] ocenyTab){
    ocenyTab = new[] { 5, 4, 3, 4, 2, 1 };
    double srednia;
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
}