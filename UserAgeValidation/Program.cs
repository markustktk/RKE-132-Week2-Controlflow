// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//rakendus palub kasutajal sisestada oma vanus
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse  "You are too young to use IG".
//else: konsoolis kuvatakse "Welcome to IG".

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean = true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if (userAgeNum >= 13) {
        Console.WriteLine("Welcome to IG!");
                         }
    else { Console.WriteLine("You are too young to use IG!");
         }
}
else
    {
        Console.WriteLine("Could not read your age");
}
//int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack


/*
if (userAge >= 13)
{
    Console.WriteLine("Welcome to IG!");
} else //if (userAge < 13)
{
    Console.WriteLine("You are too young to use IG.");
}

*/