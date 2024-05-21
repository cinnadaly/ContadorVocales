using System;
using System.Collections.Generic;
using System.Linq;

//HOLA MUNDO! Solo reemplazamos el vector por consonantes - Angel
// Hola, aqui estubo JL
// Hola soy Yammir
class ContadorDeVocalesConsola
{
    static void Main()
    {
        ConsoleKeyInfo cki;
        do
        {
            Console.WriteLine("Bienvenido al contador de Consonantes!");
            Console.WriteLine("\nFavor de ingresar un texto:");
            string textoIngresado = Console.ReadLine().ToLower();

            (int contador, Dictionary<char, int> ConsonantesEncontradas) = CountConsonantes(textoIngresado);

            Console.WriteLine("\nSe encuentran " + contador + " consonantes en el texto: " + textoIngresado + " :)");
            if (contador > 0)
            {
                Console.WriteLine("Las consonantes encontradas son:");
                foreach (var Consonante in ConsonantesEncontradas)
                {
                    Console.WriteLine($"Consonante '{Consonante.Key}' encontrada {Consonante.Value} vez/veces.");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron vocales en el texto ingresado :(");
            }
            Console.WriteLine("\nSi desea salir, presione la tecla Escape (Esc)");
            Console.WriteLine("Si desea ingresar otro texto, presione Enter.");
            cki = Console.ReadKey();
            Console.Clear();
        } while (cki.Key != ConsoleKey.Escape);
    }

    static (int, Dictionary<char, int>) CountConsonantes(string texto)
    {
        char[] consonantes = { 'b', 'c', 'd', 'f', 'g','h', 'j', 'k', 'l', 'm','n','p', 'q', 'r', 's','t', 'v', 'w', 'x', 'y', 'z' };
        Dictionary<char, int> ConsonantesEncontradas = new Dictionary<char, int>();

        int contador = 0;

        foreach (char v in texto)
        {
            if (consonantes.Contains(v))
            {
                contador++;
                if (ConsonantesEncontradas.ContainsKey(v))
                {
                    ConsonantesEncontradas[v]++;
                }
                else
                {
                    ConsonantesEncontradas[v] = 1;
                }
            }
        }

        return (contador, ConsonantesEncontradas);
    }
}
