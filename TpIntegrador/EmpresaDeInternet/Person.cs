using System;

namespace EmpresaDeInternet
{
    abstract class Person
    {
        protected string name;
        protected string lastName;
        protected int dni;

        public string Name
        {
            get {return name;}
        }
        public string LastName
        {
            get {return lastName;}
        }
        public int Dni
        {
            get {return dni;}
        }

        public Person(string name, string lastName, int dni)
        {
            this.name = name;
            this.lastName = lastName;
            this.dni = dni;
        }
    }
}
