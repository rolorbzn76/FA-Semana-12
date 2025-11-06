using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Depósito es una variable LOCAL
            int[] deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500, 
                3100 }; // Arreglo 'unidimensional' con datos fijos
            int longitud, depositoAlmanceado;
            double promedio;
            // Llamamos a las funciones
            longitud = tamanio(deposito);
            depositoAlmanceado = obtenerDeposito(deposito, 2);
            promedio = promedioDeposito(deposito);
            // Imprimimos los resultados
            Console.WriteLine($"Longitud: {longitud}");
            Console.WriteLine($"Depósito: {depositoAlmanceado}");
            Console.WriteLine($"Promedio: {promedio}");
        }
        // Función tamanio que retorna la cantidad de elementos del arreglo
        static int tamanio(int[] deposito)
        {
            return deposito.Length;
        }
        // Función obtenerDeposito que reciba una posición y retorne el depósito almacenado en dicha posición.
        static int obtenerDeposito(int[] deposito, int pos)
        {
            return deposito[pos];
        }
        // Función promedioDeposito que retorne el promedio
        static double promedioDeposito(int[] deposito)  // IMPORTANTE para la T3
        {
            int suma = 0;
            for(int i = 0; i < deposito.Length; i++)
            {
                suma += deposito[i];
            }
            return 1.0*suma/deposito.Length;
        }
    }
}
