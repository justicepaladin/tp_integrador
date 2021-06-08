using System;

namespace EmpresaDeInternet
{
    class Technical : Person
    {
        protected string area;
		protected Technical [] technicalList;
		protected int techQuantity;
		
        public Technical(string name, string lastName, int dni, string area) : base(name, lastName, dni)
        {
            this.area = area;
        }
		
		public string Area
		{
			get { return area; }
		}
		
		public void Technicians()
		{
			technicalList = new Technical[100];
			techQuantity = 0;
		}
		
		public Technical [] TechnicalList
		{
			get { return technicalList; }
		}
		
		public void addTechnician(Technical ref)
		{
			technicalList[techQuantity] = ref;
			techQuantity+=1;
		}
		
		public void deleteTechnician(Technical ref)
		{
			for(int k = Array.IndexOf(technicalList, ref); k<techQuantity; k++)
				technicalList[k] = technicalList[k+1];
			
			technicalList[techQuantity] = null;
			techQuantity = techQuantity - 1;
		}
		
        public void fixService()
        {
        }
    }
}
