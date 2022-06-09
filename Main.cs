
using System.Collections;

int option = 0;
RandomDataGenerator.Person d = new RandomDataGenerator.Person();
ArrayList people = new ArrayList();
people.Add(d);
Random randy = new Random();


Console.WriteLine("====================== Random Data Generator ======================");


//displays decision menu and send user to method of choice
do
{
    
    DisplayMenu();
    Console.WriteLine(" Please enter your choice for menu option.\n");
    option = Convert.ToInt32(Console.ReadLine());
    MenuChoice(option, people);



} while (option != 0);


static void DisplayMenu()
{
    Console.WriteLine("1.           Create Person");
    Console.WriteLine("2.           Display Person(s)");
    Console.WriteLine("3.           Remove Person");
    Console.WriteLine("4.           Random Last Name");
    Console.WriteLine("5.           Random SSN");
    Console.WriteLine("6.           Random Phone Number");
    Console.WriteLine("0.           Exit Program");
}

//switch for methods. people added to allow changes to arraylist
static void MenuChoice(int option, ArrayList people)
{
    switch (option)
    {
        case 1:
            CreatePerson(people);
            
            break;
        case 2:
            DisplayPerson(people);
            
            break;
        case 3:
            RemovePerson(people);
            
            break;
        case 4:
            RandomLastName();
            
            break;
        case 5:
            RandomSnn();
            break;
        case 6:
            RandomPhone();
            break;
        case 0:
            Console.WriteLine("Thanks for using my program");
            break;
        default:
            Console.WriteLine("Invalid Menu Choice. Please Enter Number Option");
            break;
    }
}

//creates random person
static void CreatePerson(ArrayList people)
{
    RandomDataGenerator.Person p = new RandomDataGenerator.Person();
    people.Add(p);
}

//displays all people generated
static void DisplayPerson(ArrayList people)
{
    foreach(RandomDataGenerator.Person p in people)
    {
        Console.WriteLine(p);
    }
}

//removes person by index
static void RemovePerson(ArrayList people)
{
    for(int i = 0; i < people.Count; i++)
    {
        Console.WriteLine(people);
    }

    Console.WriteLine("Which index would you like to remove?");

    int choice = Convert.ToInt32(Console.ReadLine());
    people.RemoveAt(choice);

    Console.WriteLine("Person deleted");

}

// attempt to generate last name
static void RandomLastName()
{
    RandomDataGenerator.LastName l = new RandomDataGenerator.LastName();
    
}

//attempt to generate random ssn
static void RandomSnn()
{
   RandomDataGenerator.SSN l = new RandomDataGenerator.SSN();
    Console.WriteLine(l);
}

//attempt to generate random phonenumber
static void RandomPhone()
{
    char choice = '-';
    RandomDataGenerator.Phone p = new RandomDataGenerator.Phone();
    Console.WriteLine("Choose a delimiter.");
    choice = Console.ReadKey().KeyChar;
    p.Format(choice);

    Console.WriteLine(p);
}


