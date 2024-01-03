// See https://aka.ms/new-console-template for more information
// rakendus küsib kasutajalt sisestada tema vanus
// kui vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "You are too young to use Instagram"
// muul juhul konsoolis kuvatakse:
// "Welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years. old.");


//int userAge = Int32.Parse(Console.ReadLine());

if(isAgeNumber)
{
    if(userAgeNum >= 13)
{
    Console.WriteLine("Welcome!");
}

else
{
    Console.WriteLine("Not welcome");
}
}
else
    {
        Console.WriteLine("Could do better");
    }
