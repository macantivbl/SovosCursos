using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Student
    {
        private int id;
        public int StudentId {
            get { return id; } 
            set { if(value > 0)
                    id = value; }
        }

        // id es privado ergo no puede ser accesada
        // solo podra ser accesada por StudentID 
        // get regresa el valor 
        // set asigna el valor a id 
        
    }

    internal class StudentAuto
    {
        private int id;
        public int StudentId { get; set; }

        // si no se va aplicar ninguna logica se puede hacer esta forma mas corta

    }

    /*
    class StudentName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName() { return FirstName + " " + LastName; }

    }*/

    // Constructor
    // los contructores deben de tener el mismo nombre que la clase
    // los contructores no regresan algun valor


    

    

}
