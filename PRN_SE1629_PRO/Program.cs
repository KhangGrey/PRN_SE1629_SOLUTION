namespace fptedu.se1629;//.net same as package domain in Java
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, Everyone...");
        int x = 10, y = 11;//arguments (has values)
        Console.WriteLine($"Total of a = {x} and b = {y} is : {sum(x, y)}");
        Console.ReadLine();

        var name = "Khang";
        dynamic salary = 100.5;
    }
        public static int sum(int a, int b)
        {
            return a + b;
        }
}