using System;
using System.Collections.Generic;
using System.Linq;

class ContadorDeVocalesyConsonantes
{
    static void Main()
    {
        ConsoleKeyInfo cki;
        do
        {
            Console.WriteLine("Bienvenido al contador de vocales y consonantes!");
            Console.WriteLine("\nFavor de ingresar un texto:");
            string textoIngresado = Console.ReadLine().ToLower();

            (int contadorVocales, Dictionary<char, int> vocalesEncontradas) = CountVowels(textoIngresado);
            (int contadorConsonantes, Dictionary<char, int> consonantesEncontradas) = CountConsonants(textoIngresado);

            Console.WriteLine("\nSe encuentran " + contadorVocales + " vocales en el texto: " + textoIngresado + " :)");
            if (contadorVocales > 0)
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

            Console.WriteLine("\nSe encuentran " + contadorConsonantes + " consonantes en el texto: " + textoIngresado + " :)");
            if (contadorConsonantes > 0)
            {
                Console.WriteLine("Las consonantes encontradas son:");
                foreach (var consonante in consonantesEncontradas)
                {
                    Console.WriteLine($"Consonante '{consonante.Key}' encontrada {consonante.Value} vez/veces.");
                }
            }
            else
            {
                Console.WriteLine("No se encontraron consonantes en el texto ingresado :(");
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

    static (int, Dictionary<char, int>) CountConsonants(string texto)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        Dictionary<char, int> consonantesEncontradas = new Dictionary<char, int>();

        int contador = 0;

        foreach (char c in texto)
        {
            if (char.IsLetter(c) && !vowels.Contains(c))
            {
                contador++;
                if (consonantesEncontradas.ContainsKey(c))
                {
                    consonantesEncontradas[c]++;
                }
                else
                {
                    consonantesEncontradas[c] = 1;
                }
            }
        }

        return (contador, consonantesEncontradas);
    }
}
