using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class01
{
    public class TipoEnumerador
    {
        public enum Language
        {
            PTBR, EN, RU //Não foi posto ";" pois ele não é do código, ele não precisa ser executado, somente lido e continuar dentro do parâmetro.
        }
        public Language _language = Language.PTBR; //"=" é usado para atribuição, "." é um operador de acesso, para que a gente acesse o que tem dentro dele.

        public TipoEnumerador()
        {
        }
        /*
        public TipoEnumerador(TipoEnumerador enumerador)
        {
            _language = Enum;
        }
        */
        public Language GetLanguageEnum(string lang)
        {
            switch(lang.ToLower())
            {
                case "português" :
                    return Language.PTBR;
                case "inglês" :
                    return Language.EN;
                case "russo" : 
                    return Language.RU;
                default:
                    return Language.PTBR;
            }
        }
    }
    
}