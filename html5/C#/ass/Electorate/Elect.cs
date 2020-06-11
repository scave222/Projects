namespace Electorate
{
    public class Elect
    {
        public string Name{get; set;}
        private int age;


        
        public Elect (string name, int userAge)
        {
            Name = name;
            Age = userAge;
        }

        public int Age
        {
            get{return age;}
            private set{
                if(age > 18)
               
            {
              Age = value;   
            }

           
            }

        }
        public string checkEligibility( int Age)
        {
            if(age <18 || age > 120){
                return "Not eligible to vote";
            }
            else {
                return "Eligible to vote";
            }
        }



    }
}