using System.Security.Cryptography.X509Certificates;

String FirstName = "DAVID";
//String firstName = "DAVID";
//String first_name = "DAVID";
int age = 22;

Console.WriteLine($"HEllooo {FirstName}. You are {age} years old!");
Console.WriteLine("HEllooo " + FirstName + ". You are " + age + " years old!");


Console.WriteLine($"1");
Console.WriteLine($"2");
Console.WriteLine($"3");
Console.WriteLine($"4");
Console.WriteLine("------------------------------------");


for (int i = 0; i < 30; i++)
{
	if (i % 2 == 0 )
	{
        Console.WriteLine($"{i} é un pair!");
    }
	else
	{
        Console.WriteLine($"{i} é un impair!");
    }
}

Console.WriteLine("Terminé");



// DRY - DONT REPEAT YOURSELF
