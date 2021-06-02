using System;

namespace EmpresaDeInternet
{
    class Client : Person
    {
        private int nroClient;
        private DateTime dischargeDate;
        private bool insidePromo;
        private string area;
        private Service service;
        private Technical technical; 
        
        public Client(
                string name,
                string lastName,
                int dni,
                int nroClient,
                string area
        ) : base(name, lastName, dni)
        {
            this.nroClient = nroClient;
            this.area = area;
        }

        public void contractService(Service service, DateTime promoDate)
        {
        }

        public void assignTechnical(Technical technical)
        {
        }

        public void surfingInternet()
        {
        }

        public bool modifyService(Service service)
        {
        }
    }
}
