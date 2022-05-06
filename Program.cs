// See https://aka.ms/new-console-template for more information
class Program {
    static void Main(string[] args) {
        int [] myArray = new int[10];
        int num = 0;

        Console.Write("Enter a number >");
        num = Convert.ToInt32(Console.ReadLine());
        myArray[0] = num;
        Console.WriteLine(myArray[10]);
        Console.WriteLine("\nYour Number is " + myArray[0]);
            Console.ReadKey();
    }
}
