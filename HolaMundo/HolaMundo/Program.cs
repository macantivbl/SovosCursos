using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");
            Console.ReadLine();
        }


        // Metodos

        public int Sum(int num1, int num2) { return num1 + num2; }
        public void Greet() { Console.WriteLine("Hola"); }

        // Objetos
        StudentName mystudent1 = new StudentName();
        
        

    }


    class StudentName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName() { return FirstName + " " + LastName; }

    }
}
