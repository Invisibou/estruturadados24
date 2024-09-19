//Crie um programa no qual o mesmo simule uma lotérica, na qual terá uma pilha de senhas, a senha será retirada
//com a função Peek, na qual terá outra pilha que captará as senhas já usadas e chamará a próxima.
//Stack = Pilha em Inglês

using ListaSenha;

Stack<int> password = new();

TicketDevelop ticket = new();
password.Push(27);
password.Push(28);
password.Push(29);
password.Push(30);
