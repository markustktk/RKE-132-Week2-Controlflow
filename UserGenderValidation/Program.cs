// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, Markus!");

//rakendus küsib kasuatajalt tema sugu
//rakendus laseb kasutajal sisestada perekonnanime
//lähtudes kasutaja valikust kuvab rakendus tervituse
//"Welcome, Mr. Perekonnanimi" / "Welcome Ms. Perekonnanimi"

Console.WriteLine("Please select your Gender (M/F)");

char userGender = char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your last name:");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}");
} 
else if (userGender== 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}");
} else
{
    Console.WriteLine($"Welcome! {userLastName}");
}

//Console.WriteLine($"Welcome, {userGender}");