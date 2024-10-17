using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando três listas de inteiros
        List<string> proteinas = new List<string> { "Carne Bovina", "Ovos", "Sassami", "Carne Moída", "Bistecone" };
        List<string> frutas = new List<string> { "Uva", "Morango", "Pera", "Kiwi", "Pêssego" };
        List<string> carboidratos = new List<string> { "Pão", "Pão Integral", "Macarrão", "Arroz", "Batata" };

        // Ordenando as listas usando o Tim Sort
        proteinas.Sort();
        frutas.Sort();
        carboidratos.Sort();

        // Exibindo as listas ordenadas
        Console.WriteLine("Proteínas:");
        foreach (var numero in proteinas)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("\nFrutas:");
        foreach (var numero in frutas)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("\nCarboidratos:");
        foreach (var numero in carboidratos)
        {
            Console.WriteLine(numero);
        }
    }
}