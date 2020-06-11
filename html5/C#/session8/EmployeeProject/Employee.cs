namespace EmployeeProject
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        private int age;

        public int Age{
            get{return age;}
            set {
                if(value > 0)
                {
                    age = value;
                }
            }
        }

        public Employee(int empid, string name, int age)
        {
            EmpID = empid;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Employee Name: \t{Name}\nEmployee Age:\t{Age}";
        }
    }
}