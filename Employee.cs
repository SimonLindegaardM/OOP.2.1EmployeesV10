namespace EmployeesV10
{
    public class Employee
    {
        private string _name;
        private int _hoursPerWeek;
        public Employee(string name, int hoursPerWeek)
        {
            _name= name;
            _hoursPerWeek= hoursPerWeek;
        }
        public string name
        {
            get {return _name;}
            set{_name = value;}
        }
        public int hoursPerWeek
        {
            get{return _hoursPerWeek;}
            set{_hoursPerWeek = value;}
        }

    }

}