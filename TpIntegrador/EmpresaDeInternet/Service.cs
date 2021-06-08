using System;

namespace EmpresaDeInternet
{
    class Service
    {
        private string type;
        private float price;
        private int megas;

        public string Type
        {
            get {return type;}
        }
        public float Price
        {
            get {return price;}
        }

        public Service(string type, float price, int megas)
        {
            this.type = type;
            this.price = price;
            this.megas = megas;
        }

        public void giveMegas()
        {
        }
    }
}
