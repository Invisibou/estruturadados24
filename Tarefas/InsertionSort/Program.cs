using System.Reflection.Metadata;
using AtvOrdenacao;

string[] names = new string[3]{"Marcos", "Didi", "Michael"};

AtvOrdenacao.InsertionSort.Sort(names);

foreach(string name in names)
    System.Console.WriteLine(name);