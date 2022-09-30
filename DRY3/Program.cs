/// <summary>
/// DRY, which stands for ‘don’t repeat yourself,’
/// is a principle of software development that aims at reducing 
/// the repetition of patterns and code duplication 
/// in favor of abstractions and avoiding redundancy.
/// This solution contains 3 projects , each one consdidered better than the previous one.
/// please watch this video for explanation https://youtu.be/TgvRo6zwnYY
/// aatres@ahram.org.eg
/// </summary>
/// 



using DRY3;

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
        var person = new Person("Milos Protic", 30);
        Console.WriteLine($"{person.Name} lives in {person.City}, " +
          $"{person.State} and he is {person.Age} years old!");
    }

    private static void WriteSomethingElse()
    {
        var person = new Person("John Doe", 29);
        Console.WriteLine($"{person.Name} lives in {person.City}, " +
          $"{person.State} and he is {person.Age} years old!");
    }


    private static void WriteSomethingAgain()
    {
        var person = new Person("Jack Fishing", 49);
        Console.WriteLine($"{person.Name} lives in {person.City}, " +
          $"{person.State} and he is {person.Age} years old!");
    }

}