using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtendidos
{
    class Cliente: IComparable
    {

        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, int cpf, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
        }

        public int CompareTo(object obj)
        {
            Cliente cliente = obj as Cliente;
            if (cliente is null) {
                return -1;
            }
            return this.Nome.CompareTo(cliente.Nome);                                  
        }
    }
}
