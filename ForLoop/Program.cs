// See https://aka.ms/new-console-template for more information
namespace ahmadForLoop;
class Program
{
    static void Main(string[] arg)
    {
      int a = 1;
        int[] luckyNumbers = { 10, 15, 20, 25, 30, 40}; 
       // while(i < 5) set i loop condition
        //{
          //  Console.WriteLine(i);
            //i++;  increment i by 1
        //}
        for(a =1; a<=7; a++)
        {
            Console.WriteLine(a);
        }
        for(int i = 0; i < luckyNumbers.Length; i++) 
        {
            Console.WriteLine(luckyNumbers[i]);
        }
        Console.ReadLine();
    }
}
