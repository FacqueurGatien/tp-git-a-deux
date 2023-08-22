namespace tpGitADeux
{
    public class Person
    {
        private string nom;
        private string prenom;

        public Person(string _nom, string _prenom)
        {
            nom = _nom;
            prenom = _prenom;
        }
        public Person()
        {
            nom = "";
            prenom = "";
        }
        public Person(Person _person)
        {
            nom = _person.nom;
            prenom = _person.prenom;
        }
        public override string ToString()
        {
            return $"nom: {nom}\nprenom: {prenom}";
        }
    }
}