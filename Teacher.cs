namespace EmployeesV10
{
    public class Teacher : Employee
    {
        #region Instance fields
        // private string _name;
        // private int _hoursPerWeek;
        private int _payGrade;
        #endregion

        #region Constructor
        public Teacher(string name, int hoursPerWeek, int payGrade)
        : base(name, hoursPerWeek)
        {
            _payGrade = payGrade;
        }
        #endregion

        #region Properties
        // public string Name
        // {
        //     get { return _name; }
        //     set { _name = value; }
        // }

        // public int HoursPerWeek
        // {
        //     get { return _hoursPerWeek; }
        //     set { _hoursPerWeek = value; }
        // }

        public int PayGrade
        {
            get { return _payGrade; }
            set { _payGrade = value; }
        }

        public string AllInformation
        {
            get
            {
                return $"Teacher {name} works {hoursPerWeek} hours/week, at paygrade {PayGrade}";
            }
        } 
        #endregion
    }
}
