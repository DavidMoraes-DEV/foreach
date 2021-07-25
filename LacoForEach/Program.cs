using System;

namespace LacoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             O Laço "foreach" é uma sintaxe opicional e simplificada do
            "for" padrão para percorrer coleções(Vetor, Listas mMatriz entre outros).
            Obs. É muito utilizado!!!
            */

            string[] vetor = new string[] { "Maria", "Bob", "Alex" };

            /*Se lê: "Para cada objeto 'obj' contido em um vetor, faça:
            (Esse 'obj' serve como um tipo de apelido para cada elemento
            do vetor, podendo ser outro nome qualquer)"*/
            foreach (string obj in vetor)
            {
                Console.WriteLine(obj);
                /*Para cada elemento do vetor será executado esse comando*/
            }

        }
    }
}
