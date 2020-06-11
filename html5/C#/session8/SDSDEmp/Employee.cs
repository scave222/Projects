namespace SDSDEmp
{
    public class Employee
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Address {get; set;}
        public string Gender {get; set;}
        public Date Birthday {get; set;}
        public Date HireDate {get; set;}

        public Employee(string first, string last, string address, string gender, Date birth, Date hiredate)
        {
            FirstName = first;
            LastName = last;
            Address = address;
            Gender = gender;
            Birthday = birth;
            HireDate = hiredate;
        }

    }
}