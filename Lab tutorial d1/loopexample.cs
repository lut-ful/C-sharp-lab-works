namespace Lab_tutorial;
public class LoopExample 
{
    public void forloop(int n)
    {
        Console.WriteLine("for loop example");
        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(n);
        }
    }
    public void whilelooop(int n)
    {
        Console.WriteLine("while loop example");
        int x = 1;
        while (x <= n)
        {
            Console.WriteLine(x);
            x++;
        }
    }
    public void dowhileloop(int n)
    {
        Console.WriteLine("do while loop example");
        int x = 1;
        do
        {
            Console.WriteLine(x);
            x++;
        } while (x <= n);
    }
}
