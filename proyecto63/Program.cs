using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto63
{
    internal class Personas_Alturas
    {
        private float[] alturas;
        private float suma = 0;
        private float promedio;
        private int altas = 0;
        private int bajas = 0;

        public void Inicializar()
        {
            alturas = new float[5];

            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Ingresa la altura #{i}");
                alturas[i]= float.Parse(Console.ReadLine());
            }

            Promedio();
            AltasAndBajas();
        }

        public void Promedio()
        {
            for(int i = 0; i<=4; i++)
            {
              suma = suma + alturas[i]; 
            }

            promedio = suma / 5;

            Console.WriteLine($"El promedio de las alturas es: {promedio}");
        }

        public void AltasAndBajas()
        {
            for(int i = 0; i<=4; i++)
            {
                if (alturas[i] > promedio)
                {
                    altas++;
                }
                else 
                { 
                    if(alturas[i] < promedio) bajas++;               
                }
            }

            Console.WriteLine("");
            Console.WriteLine("************ Resultados ************");
            Console.WriteLine("");

            Console.WriteLine($"Cantidad de alturas mas altas que el promedio: {altas}");
            Console.WriteLine($"Cantidad de bajas mas altas que el promedio: {bajas}");

        }

        static void Main(string[] args)
        {

            //Problema 2:
            //Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
            //Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y
            //cuántas más bajas.

            Personas_Alturas personas = new Personas_Alturas();
            personas.Inicializar();
            Console.ReadKey();
        }
    }
}
