
using tpGitADeux;

// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

name = AskName();
firstName = AskFirstName();

Person myPerson = new Person(name,firstName);
Console.WriteLine(myPerson.ToString());

string AskName()
{
    Console.WriteLine("Veuillez saisir votre nom :");
    string name Console.ReadLine();

    return Regex.IsMatch(name, @"^[\p{L}]{2,}$") ? name : AskName();

}

string AskFirstName()
{
    Console.WriteLine("Veuillez saisir votre prénom :");
    string firstName = Console.ReadLine();

    return Regex.IsMatch(firstName, @"^[\p{L}]{2,}$") ? firstName : AskFirstName();
}
