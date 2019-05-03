using System;

namespace Bucle
{
    class Program
    {
        static void Main(string[] args)
        {   //while = mientras For = mientras (la diferencia es que en el for se pueden hacer varias cosas 
            //a la vez  en una sola instruccion 
            //en el while no 
            //FOR cuando se el número de veces que quiero  repetir la acción
            //WHILE cuando no se las veces y depende de algo externo 

            //Ejemplo de While -( do -while) 
             int num;
            
            do
            {
                Console.WriteLine("Escribe un número");
                num = Convert.ToInt32( Console.ReadLine());

            } while (num >= 0);
            */

            // ejemplo de FOR
            // primero declarar la variable int normalmente llamada" i "
            // luego fuera de for declaramos otra variable para ir sumando los valores 
            // en este caso llamada suma y damos valor 0 pq todavia no vale nada
            // al final le decimos que suma vale suma + el numero que va dando el usuario

            int suma = 0;
            for (int i = 0; i < 8; i++)  
            {
                Console.WriteLine("escribe un numero");
                int num = Convert.ToInt32(Console.ReadLine());
                suma = num + suma;
            }
            Console.WriteLine(suma);


        }
    }
}
