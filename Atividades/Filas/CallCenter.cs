using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filas
{
    public class CallCenter
    {
        private int _counter = 0; //Atributo privado é somente para uso da própria classe, as outras classes não podem usar suas atribuições.
        public Queue<IncomingCall>? Calls { get; set;} //? = possível de ser nulo
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }

        // Método para abertura de chamados
        public void  Call(int clientId)
        {
            Calls!.Enqueue
            (
                new IncomingCall()
                    {
                    Id = ++_counter,
                    ClientId = clientId,
                    CallTime = DateTime.Now
                    }
            );
        }
        public IncomingCall Answer(string consultant)
        {
            // Validação:  Verificar se tem atendimentos na fila
            if(Calls!.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;

                return call;
            }
            return null!;
        }
        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }
        public bool  AreWaitingCalls()
        {
            return (Calls!.Count > 0); // ! = se tem o !, significa que naquele ponto, não poderá ser nulo
        }
    }
}