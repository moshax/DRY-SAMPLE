/// <summary>
/// DRY, which stands for ‘don’t repeat yourself,’
/// is a principle of software development that aims at reducing 
/// the repetition of patterns and code duplication 
/// in favor of abstractions and avoiding redundancy.
/// This solution contains 3 projects , each one consdidered better than the previous one.
/// aatres@ahram.org.eg
/// please watch this video for explanation https://youtu.be/TgvRo6zwnYY
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        WriteSomething();
        WriteSomethingElse();
        WriteSomethingAgain();
        Console.ReadLine();
    }

    private static void WriteSomething()
    {
        var city = "Novi Sad";
        var state = "Serbia";
        var name = "Milos Protic";
        var age = 30;

        Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
    }

    private static void WriteSomethingElse()
    {
        var city = "Novi Sad";
        var state = "Serbia";
        var name = "John Doe";
        var age = 29;

        Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
    }


    private static void WriteSomethingAgain()
    {
        var city = "Novi Sad";
        var state = "Serbia";
        var name = "Jack Fishing";
        var age = 45;

        Console.WriteLine($"{name} lives in {city}, {state} and he is {age} years old!");
    }
}