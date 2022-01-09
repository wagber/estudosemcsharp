using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Comentário de uma linha
/*
  Comentário de várias linhas
 */

/*
using System; -> A using Systemlinha significa que você está usando a Systembiblioteca em seu projeto.
O que fornece algumas classes e funções úteis, como Consoleclass ou a WriteLinefunção / método.

using System.Collections.Generic; -> Contém interfaces e classes que definem coleções genéricas, que permitem
aos usuários criar coleções fortemente tipadas que oferecem melhor desempenho e segurança de tipos do que coleções
fortemente tipadas não genéricas.

using System.Linq; ->
using System.Text; ->
using System.Threading.Tasks; ->
using System.Globalization; ->
 */

namespace Ola_Mundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Resultado = " + x);
            Console.WriteLine("Resultado = " + x.ToString("F2"));
            Console.WriteLine("Resultado = " + x.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

/*
Com quebra de linha
    Console.WriteLine("Olá Mundo!");

Sem quebra de linha
    Console.Write("Olá ");
    Console.Write("Mundo!");
 */

/*
 Variável que aceita casas decimais, ou seja, pontos flutuantes do tipo Double.
 */

/*
 Usamos o sinal de + para concatenar vários elementos em um mesmo comando de escrita.
 */


