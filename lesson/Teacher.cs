namespace lesson
{
    public class Teacher : ClassMember
    {
        public string Name {
            get
            {
                return this.name;
            }
        }

        private string name;

        public string Title { 
            get
            {
                return this.title;
            }
        }

        private string title;

        public Teacher(string name, string title)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty");
            }

            this.name = name;
            this.title = title;
        }
    }
}
