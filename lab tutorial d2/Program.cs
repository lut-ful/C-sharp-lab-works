namespace lab_tutorial_d2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the class

            //task 1
            /**
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);

            heikkisAccount.Withdraw(20);
            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
            heikkisSwissAccount.Deposit(200);
            Console.WriteLine("The balance of  Heikki's other account is now: " + heikkisSwissAccount.balance);
            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(heikkisSwissAccount);
            **/
            //task 2
            /**
            Account heikkis_acc=new Account("Heikki's account", 1000.00);
            Account personal=new Account("Personal account", 0.00);
            heikkis_acc.Withdraw(100.00);
            personal.Deposit(100.00);
            Console.WriteLine("Heikki's account balance: "+heikkis_acc.balance);
            Console.WriteLine("Personal account balance: "+personal.balance);
            **/
            //task 3
            /**
            Dog defaultDog=new Dog();
            Console.WriteLine(defaultDog.ToString());
            defaultDog.name="Rex";
            defaultDog.breed="German Shepherd";
            defaultDog.age=5;
            Console.WriteLine(defaultDog.ToString());

            defaultDog.bark();
            defaultDog.fetch("ball");

            Dog anotherDog=new Dog();   
            anotherDog.bark();
            anotherDog.fetch("stick");
            **/
            //task 4
            /**
            Room defaultRoom = new Room();
            Console.WriteLine(defaultRoom.ToString());
            defaultRoom.Code = "A101";
            defaultRoom.Seats = 30;
            Console.WriteLine(defaultRoom.ToString());

            Room anotherRoom= new Room("B202", 50);
            Console.WriteLine(anotherRoom.ToString());

            defaultRoom.occupy();
            anotherRoom.vacate();

            anotherRoom.occupy();
            defaultRoom.vacate();
            **/

            //task 5
            /**
            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle =new Whistle("Peef"); 
            duckWhistle.SoundWhistle();

            Whistle myWhistle = new Whistle();
            myWhistle.Sound = "Tweet";
            myWhistle.SoundWhistle();

            myWhistle.Sound = "";
            myWhistle.SoundWhistle();

            myWhistle.ChangeSound("Whistle-Whistle");
            myWhistle.SoundWhistle();
            **/

            //task 6

             
        }
    }
}