using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtendidos.Comparadores
{
    class ComparadorEmailCliente : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y)
        {
            if (x is null && y is null)
            {
                return 0;
            }
            if (x is null) {
                return 1;
            }
            if (y is null) {
                return -1;
            }
            return x.Email.CompareTo(y.Email);
        }
    }
}
