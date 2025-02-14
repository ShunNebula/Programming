namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о школьной дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;
        /// <summary>
        /// ФИО учителя.
        /// </summary>
        private string _teacher;
        /// <summary>
        /// Оценка.
        /// </summary>
        private string _grade;

        /// <summary>
        /// Возвращает и задает название.
        /// </summary>
        public string Name
        { get { return _name; } set {  _name = value; } }
        /// <summary>
        /// ВОзвращает и задает ФИО учителя.
        /// </summary>
        public string Teacher
        { get { return _teacher; } set { _teacher = value; } }
        /// <summary>
        /// Оценка.
        /// </summary>
        public string Grade
        { get { return _grade; } set { _grade = value; } }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
            
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="teacher">ФИО учителя.</param>
        /// <param name="grade">Оценка.</param>
        public Subject(string name, string teacher, string grade)
        {
            Name = name;
            Teacher = teacher;
            Grade = grade;
        }
    }
}
