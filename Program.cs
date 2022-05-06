// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(string[] args) {
        int [] myArray = new int[10];
        for (int i=0; i<10;i++)
        {
            Console.Write("Enter a number >");
            myArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Here are your numbers: ");
        for (int i=0; i<10;i++) 
        {
            Console.WriteLine(myArray[i]);
        }
        Console.ReadKey();
    }
}