// See https://aka.ms/new-console-template for more information


using System.Text.RegularExpressions;

string name = "";
string firstName = "";

name = AskName();
firstName = AskFirstName();

string AskName()
{
    Console.WriteLine("Veuillez saisir votre nom(lettres uniquement) :");
    string name = Console.ReadLine();
    return Regex.IsMatch(name, @"^[\p{L}]{2,}$") ? name : AskName();

}

string AskFirstName()
{
    Console.WriteLine("Veuillez saisir votre prénom(lettres uniquement) : ");
    string firstName = Console.ReadLine();
    return Regex.IsMatch(firstName, @"^[\p{L}]{2,}$") ? firstName : AskFirstName();
}

