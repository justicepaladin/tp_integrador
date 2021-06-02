using System;
using System.Collections;

namespace EmpresaDeInternet
{ 
    class Business
    {
        private string name;
        private ArrayList technicals;
        private ArrayList services;
        private ArrayList clients;
        private int quotas;

        public ArrayList Technicals
        {
            get { return technicals; }
            set { technicals = value; }
        }

        public ArrayList Service
        { 
            get { return services; } 
            set { services = value; }
        }

        public ArrayList Clients
        {
            get { return clients; }
            set { clients = value; }
        }

        public Business(string name, int quotas)
        {
            this.name = name;
            this.quotas = quotas;
        }

        public void deleteTechnical(Technical technical)
        {
        }

        public void deleteClient(Client client)
        {
        }

        public void deleteService(Service service)
        {
        }
    }
}
