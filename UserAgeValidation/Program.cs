// rakendus küsib kasutajal valida tema sugu m/f
// rakendus küsib kasutaja nime
// rakendus väljastab tervituse "Welcome mr/mrs kasutaja perekonnanimi"

Console.WriteLine("Please, selet your gender (m/f):");
// Console.ReadLine(); loeb stringina 
char userGender = char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your name:");
string userLastname = Console.ReadLine();


if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr {userLastname} !");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms {userLastname} !");
}
else
{
    Console.WriteLine($"Welcome, {userLastname} !");

}


