using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPracticos2_RLG
{
    internal class Ejercicios6
    {
        public void TresArrays()
        {
            Console.WriteLine("Escribe el tamaño de los arrays");
            int valores =int.Parse(Console.ReadLine());
            int[] array1 = new int[valores];
            int[] array2 = new int[valores];
            int[] arraySuma = new int[valores];
            int posicion1 ;
            int posicion2 ;
            int posicion3 ;
            for (int i = 0; i < array1.Length; i++)
            {
                posicion1 = i; posicion2 =i;
                Console.WriteLine($"Escriba el valor en una posicion {posicion1} en el primer array");
                array1[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Escriba el valor en una posicion {posicion2} en el segundo array");
                array2[i] = Convert.ToInt32(Console.ReadLine());

                 posicion1++;
                 posicion2++;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                int suma = array1[i] + array2[i];
                arraySuma[i] = suma;
            }
            for(int i = 0;i < arraySuma.Length; i++)
            {
                posicion1 = i; posicion2 = i; posicion3 = i;
                Console.WriteLine($"valor posicion {posicion1} es {array1[i]} + valor posicion {posicion2} es {array2[i]} = valor posicion {posicion3} es {arraySuma[i]}");
                posicion3++;
                posicion1++;
                posicion2++;
            }
        }

        public void BuscarElementoArray()
        {

        }
    }
}
