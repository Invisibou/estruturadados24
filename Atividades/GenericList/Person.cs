using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenericList
{
    public enum CountryEnum{
        BR, PY, JP, IT, AR, 
    }
    public class Person
    {
        public string? Name { get; set; }

        public int? Age { get; set; }

        public CountryEnum Country { get; set;}
    }
}