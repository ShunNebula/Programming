namespace Programming.Model
{
    public class Subject
    {
        private string _name;
        private string _teacher;
        private string _grade;

        public string Name
        { get { return _name; } set {  _name = value; } }
        public string Teacher
        { get { return _teacher; } set { _teacher = value; } }
        public string Grade
        { get { return _grade; } set { _grade = value; } }

        public Subject()
        {
            
        }

        public Subject(string name, string teacher, string grade)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }
    }
}
