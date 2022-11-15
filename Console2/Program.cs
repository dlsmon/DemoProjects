
//VAR
string Name = "";
int Age = 0;
int BirthYear = 0;
int CurrentYear = DateTime.Today.Year;

//GET NAME
while (Name == "")
{
    Console.WriteLine("Entre ton nom : ");
    Name = Console.ReadLine();
}
Console.WriteLine($"Tu t'appelle {Name}.");

//GET BIRTH YEAR
while (BirthYear < 1800 || BirthYear > CurrentYear)
{
    Console.Write("Quelle est votre date de naissance? : ");
    if (!int.TryParse(Console.ReadLine(), out BirthYear))
    {
        Console.Write("Il faut appuyer un nombre! ");
    }
    else
    {
        if (BirthYear < 1800)
        {
            Console.Write("T'es une fantasme! ");
        }
        else if (BirthYear > CurrentYear)
        {
            Console.Write("Tu n'es pas encore né! ");
        }
    }     
}

//CONCLUSION 
Age = CurrentYear - BirthYear;
Console.WriteLine($"Tu t'appelle {Name}. Tu as {Age} ans.");



