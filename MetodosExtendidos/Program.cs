using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosExtendidos.Comparadores;

namespace MetodosExtendidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Descomentar para testar.
            //testeRemoverVarios();
            //testeRemoverVariosPorIndex();
            testeSortCliente();

          
            Console.ReadLine();
        }

        static void testeRemoverVariosPorIndex() {

            List<int> idades = new List<int>() { 17, 26 };
            

            try
            {
                idades.AdicionarVarios(12, 58, 59, 65, 12, 14);
                idades.RemoverVariosPorIndex(6, 3, 0, 1,9);
                idades.ForEach(i => Console.WriteLine(i));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
          
        }

        static void testeRemoverVarios()
        {

            List<int> idades = new List<int>() { 17, 26 };

            try
            {
                idades.AdicionarVarios(12, 58, 59, 65, 12, 14);
                idades.RemoverVarios(59, 65, 12);

                idades.ForEach(i => Console.WriteLine(i));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }

        static void testeSortCliente() {

            List<Cliente> clientes = new List<Cliente>() {
                 new Cliente("Felipe", 5548475, "alvesfelipe@gmail.com"),
                 new Cliente("Amanda", 5584898, "amanda@gmail.com"),
                 new Cliente("Rafael", 7858475, "Rafael@gmail.com"),
                 new Cliente("Julia",  7906898, "Julia@gmail.com"),
            };

            //-> Usa a interface IComparable 
            clientes.Sort();
            // -> Usa a interface IComparer<T>
            clientes.Sort(new ComparadorEmailCliente());

            clientes.ForEach(cliente =>
            {
                if (cliente != null)
                    Console.WriteLine($"Nome {cliente.Nome}, CPF {cliente.Cpf}, email {cliente.Email}");
            });



            #region Usando o orderby
                                 
            //// -> usar orderBy que tem retorno IOrderedEnumerable<T> 
            //var clientesOrdenados = clientes.OrderBy(cliente => 
            //    {
            //        if (cliente == null) { 
            //            return int.MaxValue;
            //        }

            //        return cliente.Cpf;
            //    }
            //);

            //clientesOrdenados.ToList().ForEach(cliente => {
            //    if (cliente != null)
            //        Console.WriteLine($"Nome {cliente.Nome}, CPF {cliente.Cpf}, email {cliente.Email}");
            //    }
            //);

            #endregion
        }
    }
}
