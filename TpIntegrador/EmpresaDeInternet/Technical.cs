using System;

namespace EmpresaDeInternet
{
    class Technical : Person
    {
        protected string area;

        public Technical(string name, string lastName, int dni, string area) : base(name, lastName, dni)
        {
            this.area = area;
        }

        public void fixService()
        {
        }
    }
}
