using Class01;
//Comentário de uma linha
/*
    Comentário de múltiplas linhas
*/

//Declarando variávells
int number;
//Atribuindo valor
number = 10;

//Declarando constante
const int DAYS_IN_WEEK = 7;

//Imprimindo String Concatenada
Console.WriteLine( $"A semana tem {DAYS_IN_WEEK} dias");

/*new TipoEnumerador() -> Invoca o método construtor do objeto
Toda classe tem o seu construtor padrão implícito sem argumentos/parâmetros
É possível sobrescrever este método se especificando argumentos
Todavia, se o fizermos, perdemos o original implícito e
precisaremos defini-lo explicitamente*/
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish =
    tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine( $"O enum de english é {enumEnglish}" );