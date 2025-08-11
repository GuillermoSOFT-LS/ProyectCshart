using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto61
{
    internal class Operacion
    {          
        
        int v1, v2, v3,mayor,menor;
        public void Iniciarlizar()
        {
            for (int i = 1; i<=3; i++)
            {      
                Console.WriteLine($"Ingrese el valor {i}:");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (i == 1) v1 = valor;
                if (i == 2) v2 = valor;
                if (i == 3) v3 = valor;

                mayor = Mayor(v1, v2, v3);
                menor = Menor(v1, v2, v3);

                
            }
             Console.WriteLine($"El valor mayor es: {mayor}");
             Console.WriteLine($"El valor menor es: {menor}");
        }

        public int Mayor(int v1, int v2, int v3)
        {
            if (v1 > v2 && v1 > v3) return v1;
            else
            {
                if(v2 > v1 && v2 > v3) return v2;
                else return v3;
            }            
        }

        public int Menor(int v1, int v2, int v3)
        {
            if (v1 < v2 && v1 < v3) return v1;
            else
            {
                if (v2 < v1 && v2 < v3) return v2;
                else return v3;
            }
        }



        static void Main(string[] args)
        {
            //Problema 2:
            //Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el
            //menor
            Operacion operacion = new Operacion();
            operacion.Iniciarlizar();
            Console.ReadKey();
        }
    }
}
