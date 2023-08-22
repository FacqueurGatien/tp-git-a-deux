
using tpGitADeux;
using System.Text.RegularExpressions;

string AskName()
{
    Console.WriteLine("Veuillez saisir votre nom :");
    string name = Console.ReadLine();

    return Regex.IsMatch(name, @"^[\p{L}]{2,}$") ? name : AskName();

}

string AskFirstName()
{
    Console.WriteLine("Veuillez saisir votre prénom :");
    string firstName = Console.ReadLine();

    return Regex.IsMatch(firstName, @"^[\p{L}]{2,}$") ? firstName : AskFirstName();
}

Person myPerson = new Person(AskName(),AskFirstName());
Console.WriteLine(myPerson.ToString());


