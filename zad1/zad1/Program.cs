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
    }
}
