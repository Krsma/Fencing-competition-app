namespace Fencing_app
{
    internal class fencer
    {
        public string name;
        public string club_name;
        public string weapon;
        public string category;
        public int score = 0;
        public int ranking = 0;

        public fencer(string name, string club, string weapon, string category)
        {
            this.name = name;
            this.club_name = name;
            this.weapon = weapon;
            this.category = category;
        }
        public override string ToString()
        {
            return "Fencer: " + name + " " + weapon + " " + category;
        }
    }
}