using System;
using System.Collections.Generic;
using System.Linq;

//HOLA MUNDO
class ContadorDeVocalesConsola
{
    static void Main()
    {
        ConsoleKeyInfo cki;
        do
        {
            Console.WriteLine("Bienvenido al contador de vocales!");
            Console.WriteLine("\nFavor de ingresar un texto:");
            string textoIngresado = Console.ReadLine().ToLower();

            (int contador, Dictionary<char, int> vocalesEncontradas) = CountVowels(textoIngresado);

            Console.WriteLine("\nSe encuentran " + contador + " vocales en el texto: " + textoIngresado + " :)");
            if (contador > 0)
            {
                Console.WriteLine("Las vocales encontradas son:");
                foreach (var vocal in vocalesEncontradas)
                {
                    Console.WriteLine($"Vocal '{vocal.Key}' encontrada {vocal.Value} vez/veces.");
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

    static (int, Dictionary<char, int>) CountVowels(string texto)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        Dictionary<char, int> vocalesEncontradas = new Dictionary<char, int>();

        int contador = 0;

        foreach (char v in texto)
        {
            if (vowels.Contains(v))
            {
                contador++;
                if (vocalesEncontradas.ContainsKey(v))
                {
                    vocalesEncontradas[v]++;
                }
                else
                {
                    vocalesEncontradas[v] = 1;
                }
            }
        }

        return (contador, vocalesEncontradas);
    }
}
