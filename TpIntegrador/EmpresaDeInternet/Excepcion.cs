using System;
using System.Collections;

namespace EmpresaDeInternet
{
    class DeleteNotFoundExeption : Exception
    {
        private string message;
        public DeleteNotFoundExeption(string element, ArrayList elements)
        {
            message = $"No se a encontrado al elemento ${element} en {elements}";
        }
    }
}
