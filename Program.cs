using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person me = new Person("Małgorzata", "Mielczarek");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nazywam się " + me.Name + " " + me.Surname + ".");
        }
    }
}
