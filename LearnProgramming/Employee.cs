namespace LearnProgramming
{
    partial class Employee
    {
        double salary;
        string FirstName;
        double _Percent;

        public string Firstname
        {
            get { return FirstName; }
           private set { FirstName = value; }
        }

        public double Salary
        {
            get { return salary; }
          private set { salary = value; }
        }

        public Employee(string name, double salary)
        {
            this.FirstName = name;
            this.salary = salary;
        }

        public Employee()
        {
        }

        public void GiveRaise(double percent)
        {
            double increament = (1.0 + percent / 100.0);
            this._Percent = percent;
            salary *= increament;
        }
        public object IncreamentPercent()
        {
            double old=Salary;
            var temp=old -= salary;
            return temp;
        }
    }
}
