namespace PersonTest
{
    public class Person
    {
        private string name;
        private int age;
        private string address;

        public string getName(){
            return name;
        }

        public void setName(string Name){
            name = Name;
        }

        public int getAge(){
            return age;
        }

        public void setAge(int Age){
            age = Age;
        }

        public string getAddress(){
            return address;
        }

        public void setAddress(string Address){
            address = Address;
        }

        public string displayDetails()
        {
            return "Your name is " + name + " and your age is " + age + " living at " + address;
        }

    }
}