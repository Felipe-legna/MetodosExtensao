using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosExtendidos
{
    public static class ExtensionList
    {
        //Criando método de extensão genérico para adicionar varios elmentos em uma lista.
        //Na chamada do método não é necessário declarar o tipo, pois como parametro ele tem uma classe com o mesmo tipo ("LISTA")
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens) {
            foreach (T item in itens) {
                lista.Add(item);
            }
        }


        /// <summary>
        /// Remove vários elementos pelas referências
        /// </summary>
        public static void RemoverVarios<T>(this List<T> lista, params T[] itens) {
            foreach (T item in itens) {
                lista.Remove(item);
            }
        }


        /// <summary>
        /// Remove vários elementos pelos índices.
        /// </summary>
        public static void RemoverVariosPorIndex<T>(this List<T> lista, params int[] itens)
        {
            Array.Sort(itens);
            Array.Reverse(itens);

            if (Array.IndexOf(itens, itens[0]) == -1) {
                throw new ArgumentOutOfRangeException();
            }

            foreach (int item in itens)
            {
                lista.RemoveAt(item);                
            }
        }

    }
}
