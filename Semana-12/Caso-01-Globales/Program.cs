using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01_Globales
{
    internal class Program
    {
        // Depósito es una variable GLOBAL
        static int[] deposito = { 3700, 3200, 2300, 2200, 3500, 2100, 3900, 8000, 2500,
                3100 }; // Arreglo 'unidimensional' con datos fijos
        static int longitud, depositoAlmanceado, mayor, menor, mayor3000, menor2500, posPrimero, posUltimo, posUltimo2, posSegundo;
        static double promedio;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la posición: ");
            int pos = int.Parse(Console.ReadLine());
            // Llamamos a las funciones
            longitud = tamanio();
            depositoAlmanceado = obtenerDeposito(pos);
            promedio = promedioDeposito();
            mayor = depositoMayor();
            menor = depositoMenor();
            mayor3000 = cantidadMayores3000();
            menor2500 = cantidadMenores2500();
            posPrimero = posPrimerDeposito();
            posUltimo = posUltimoDeposito();
            posUltimo2 = posUltimoDepositoForma2();
            posSegundo = posSegundoDeposito();
            imprimirResultados();
            generarDepositos();
        }
        // Función void que imprime los resultados
        static void imprimirResultados()
        {
            Console.WriteLine($"Longitud: {longitud}");
            Console.WriteLine($"Depósito: {depositoAlmanceado}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine($"Mayor: {mayor}");
            Console.WriteLine($"Menor: {menor}");
            Console.WriteLine($"Mayores a 3000: {mayor3000}");
            Console.WriteLine($"Menores a 2500: {menor2500}");
            Console.WriteLine($"Posición del primero entre 2000 y 2500: {posPrimero}");
            Console.WriteLine($"Posición del último entre 3500 a 4000: {posUltimo}");
            Console.WriteLine($"Posición del último entre 3500 a 4000 forma 2: {posUltimo2}");
            Console.WriteLine($"Posición del segundo entre 2000 y 2500: {posSegundo}");
        }
        // Función tamanio que retorna la cantidad de elementos del arreglo
        static int tamanio()
        {
            return deposito.Length;
        }
        // Función obtenerDeposito que reciba una posición y retorne el depósito almacenado en dicha posición.
        static int obtenerDeposito(int pos)
        {
            return deposito[pos];
        }
        // Función promedioDeposito que retorne el promedio
        static double promedioDeposito()  // IMPORTANTE para la T3
        {
            int suma = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                suma += deposito[i];
            }
            return 1.0 * suma / deposito.Length;
        }
        // Función depositoMayor que retorne el mayor
        static int depositoMayor()
        {
            int mayor = deposito[0];
            for (int i = 0; i < deposito.Length; i++)   // Para calcular el mayor o el menor, se usa FOR
            {
                if(deposito[i] > mayor)
                    mayor = deposito[i];
            }
            return mayor;
        }
        // Función depositoMenor que retorne el menor
        static int depositoMenor()
        {
            int menor = deposito[0];
            for (int i = 0; i < deposito.Length; i++)   // Para calcular el mayor o el menor, se usa FOR
            {
                if (deposito[i] < menor)
                    menor = deposito[i];
            }
            return menor;
        }
        // Función cantidadMayores3000 que retorne la cantidad de depósitos mayores a 3000
        static int cantidadMayores3000()
        {
            int can1 = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] > 3000)
                    can1++;
            }
            return can1;
        }
        // Función cantidadMenores2500 que retorne la cantidad de depósitos menores a 2500
        static int cantidadMenores2500()
        {
            int can2 = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] < 2500)
                    can2++;
            }
            return can2;
        }
        // Función posPrimerDeposito que retorne la posición del primer depósito encontrado en el rango de 2000 a 2500.
        // En caso no exista, deberá retornar -1.
        static int posPrimerDeposito()
        {
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                    return i;
            }
            return -1;
        }
        // Función posUltimoDeposito que retorne la posición del último depósito encontrado en el rango de 3500 a 4000.
        // En caso no exista, deberá retornar -1.
        static int posUltimoDeposito()
        {
            // Primera forma
            int pos = -1; 
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000)
                    pos = i;
            }
            return pos;
        }

        static int posUltimoDepositoForma2()
        {
            // Segunda forma
            for (int i = deposito.Length - 1; i >= 0; i--)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000)
                    return i;
            }
            return -1;
        }
        // Función posSegundoDeposito que retorne la posición del SEGUNDO depósito encontrado en el rango de 2000 a 2500.
        // En caso no exista, deberá retornar -1.
        static int posSegundoDeposito()
        {
            int can = 0;
            for (int i = 0; i < deposito.Length; i++)
            {
                if (deposito[i] >= 2000 && deposito[i] <= 2500)
                {
                    can++;
                    if(can == 2)
                        return i;
                }
            }
            return -1;
        }
        // Función posPenultimoDeposito que retorne la posición del penúltimo depósito encontrado en el rango de 3500 a 4000.
        // En caso no exista, deberá retornar -1.
        static int pospenultimoDeposito()
        {
            int can = 0;
            for (int i = deposito.Length - 1; i >= 0; i--)
            {
                if (deposito[i] >= 3500 && deposito[i] <= 4000)
                {
                    can++;
                    if(can == 2)
                        return i;
                }
            }
            return -1;
        }
        // Función generarDepositos que reemplace los depósitos actuales por otros valores aleatorios comprendidos
        // en el rango 2000 a 10000
        static void generarDepositos()      // NO viene en la T3
        {
            Random rnd = new Random();
            for (int i = 0; i < deposito.Length; i++)
                deposito[i] = rnd.Next(2000,10001);

            for (int i = 0; i < deposito.Length; i++)
                Console.WriteLine(deposito[i]);
        }
        // Función intercambiarDepositos que reciba como parámetros 2 posiciones y ejecute el intercambio de depósitos
        // de dichas posiciones del arreglo
        static void intercambiarDepositos(int pos1, int pos2)
        {
            int aux = deposito[pos1];
            deposito[pos1] = deposito[pos2];
            deposito[pos2] = aux;
        }
    }
}
