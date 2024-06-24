namespace Lab_tutorial;
public class Labs
{
    public static void Main(String[] args)
    {
        /** Console.WriteLine("hello");
        new LoopExample().forloop(10);
        new LoopExample().whilelooop(10);
        new LoopExample().dowhileloop(10);
        new statements();
        new readinput();
        new ifelse();
        new diagonaleStar(5);
        **/
        //new switchstatement().get;

        Person person = new Person();
        person.Name = "John Doe";
        person.Age = 30;
        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");
    }
}
