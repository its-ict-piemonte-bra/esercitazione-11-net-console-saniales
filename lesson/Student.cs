namespace lesson
{
    public class Student : ClassMember
    {
        public string Name { 
            get
            {
                return this.name;
            }
        }

        private string name;

        public Student(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }

            this.name = name;
        }
    }
}
