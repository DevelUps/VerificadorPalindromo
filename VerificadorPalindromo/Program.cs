using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorPalindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verifica si una palabra es palindroma

            string palabraUsuario, palabraInvertida = "";

            //Pedimos la palabra

            Console.Write("Ingresa una palabra y verificaremos si es palindroma: ");
            palabraUsuario = Console.ReadLine();

            foreach (char letra in palabraUsuario)
            {
                palabraInvertida = letra + palabraInvertida;
            }
            if (palabraUsuario.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"\"{palabraUsuario}\" es una palabra palindroma");
            }
            else
            {
                Console.WriteLine($"\"{palabraUsuario}\" No es una palabra palindroma");
            }
           

        }
    }
}
