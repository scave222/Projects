namespace mine
{
    public class me
    {
        public string Name {get; set;}
        private int age;

        public me(string name, int ag)
        {
            Name = name;
            Age = ag;
        }

        public int Age{
            get {return age;}
            set {
                if(age > 0)
                {
                    age = value;
                }
            }



        }
    }
}