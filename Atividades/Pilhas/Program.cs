//Basicamente as pilhas trabalham com uma estrutura LIFO -> Last In First Out, o último que entra é o primeiro que sai
//Três métodos importantes:
//Push() -> Insere um elemento no topo da pilha
//Pop() -> Remove um elemento do topo e o retorna
//Peek() -> Retorna o elemento do topo sem removê-lo

/*Invertendo as bolas 
Stack <Char> caracteres = new Stack<char>();
foreach(char c in "DARCY DA MONTANHA")
{
    caracteres.Push(c);
}

//desempilhando
string invertido = string.Empty;
while(caracteres.Count > 0)
{
    invertido += caracteres.Pop();
}

Console.WriteLine(invertido);
//Código completo da inversão de palavras.
*/
////////////////////////////
Stack <Char> caracteres = new Stack<char>();
Console.Write("Insira uma palavra: ");
char? palavra = Console.ReadLine();

foreach char c in ""