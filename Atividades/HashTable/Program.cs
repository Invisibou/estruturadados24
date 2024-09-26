// Exemplo de uma agenda telefônica

using System.Collections;

Hashtable phoneBook = new Hashtable() //Método Construtor, pois tem o mesmo nome da classe, a classe que define o tipo da variável.
{
    //{ "Chave", "Valor"},
    { "Thomazzi", "49-9961-0150" },
    { "Mauricio Gonzatto", "49-99975-8575" },
    { "Gabriel Bianchi", "49-99105-8904" } //Como é o último, não precisa de vírgula
}; // O ";" tem que ir no final, pois é para finalizar sentença, caso fosse nos "()", não leria o resto.

// É possível adicionar elementos de diversas formas pelo próprio índice chave inexistente
phoneBook["Thiago Padilha"] = "49-99176-8255";

// Ou pelo método Add()
phoneBook.Add("Marcos Henrique", "49-99202-6169");

//Entretanto, a TabelaHash verifica se há duplicidade e chave e pode lançar uma Exception
try //Imagina o try-catch como se fosse um "If" "Else", mas tem diferenças.
{
    phoneBook.Add("Mauricio Gonzatto", "49-99975-8575");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido.");
    Console.WriteLine(ex.Message);
}

//Percorrendo itens da HashTable
Console.WriteLine("Agenda telefônica:");
if(phoneBook.Count == 0) //Não precisou de chaves, pois se tiver somente uma função, não precisa, a única função dentro do IF, é o Console.WriteLine.
    Console.WriteLine("A agenda está vazia.");
else
    foreach(DictionaryEntry entry in phoneBook) //A única função dentro do Else, é o foreach.
            Console.WriteLine($"{entry.Key}:{entry.Value}"); // A única função dentro do foreach, é Console.WriteLine