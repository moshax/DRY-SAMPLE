/// <summary>
/// DRY, which stands for ‘don’t repeat yourself,’
/// is a principle of software development that aims at reducing 
/// the repetition of patterns and code duplication 
/// in favor of abstractions and avoiding redundancy.
/// This solution contains 3 projects , each one consdidered better than the previous one.
/// please watch this video for explanation https://youtu.be/TgvRo6zwnYY
/// aatres@ahram.org.eg
/// </summary>

class Program
{
    private const string CITY = "Novi Sad";
    private const string STATE = "Serbia";

    static void Main(string[] args)
    {
        WriteSomething();
        WriteSomethingElse();
        WriteSomethingAgain();
        Console.ReadLine();
    }

    private static void WriteSomething()
    {
        var name = "Milos Protic";
        var age = 30;

        Console.WriteLine($"{name} lives in {CITY}, {STATE} and he is {age} years old!");
    }

    private static void WriteSomethingElse()
    {
        var name = "John Doe";
        var age = 29;

        Console.WriteLine($"{name} lives in {CITY}, {STATE} and he is {age} years old!");
    }


    private static void WriteSomethingAgain()
    {
        var name = "Jack Fishing";
        var age = 45;

        Console.WriteLine($"{name} lives in {CITY}, {STATE} and he is {age} years old!");
    }
}