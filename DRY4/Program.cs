/// <summary>
/// DRY, which stands for ‘don’t repeat yourself,’
/// is a principle of software development that aims at reducing 
/// the repetition of patterns and code duplication 
/// in favor of abstractions and avoiding redundancy.
/// This solution contains 3 projects , each one consdidered better than the previous one.
/// aatres@ahram.org.eg
/// please watch this video for explanation https://youtu.be/TgvRo6zwnYY
/// </summary>
/// 

using DRY4;

class Program
{
    static void Main(string[] args)
    {
        PrintPersonsInformation();
        Console.ReadLine();
    }

    private static void PrintPersonsInformation()
    {
        var persons = new List<Person>()
    {
      new Person("Milos Protic", 30),
      new Person("John Doe", 29),
      new Person("Jack Fishing", 49)
    };

        persons.ForEach(
          person => person.PrintInformation()
        );
    }
}