namespace Lab_tutorial
{
    internal class ifelse
    {
        public ifelse()
        {
            Console.WriteLine("Are you a student?True/False ");
            if (bool.TryParse(Console.ReadLine(), out bool isStudent))
            {
                Console.WriteLine($"You are a student: {isStudent}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter True or False.");
            }
            Console.ReadLine();
        }
    }
}
