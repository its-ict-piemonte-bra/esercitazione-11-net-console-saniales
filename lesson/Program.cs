namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Gestione classi");

            Student s = new Student("Mario");
            Student s2 = new Student("Luigi");

            Teacher t = new Teacher("Alessandro Sanino", "CS Teacher");

            Console.WriteLine(t.Title);

            ClassMember[] members = new ClassMember[] { s, s2, t };


            Class classe = new Class("ITS-DotNet", members);

            Console.WriteLine($"{classe}");
        }
    }
}
