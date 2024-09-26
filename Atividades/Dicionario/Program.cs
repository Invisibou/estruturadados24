// Unlike the HashTable, the Dictionary allows us to specify the data type that will be used in the Key -> Value pairs. This provides us with a strongly typed structure.

using Dicionario;

Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
    { "Key 1", "Key 1" },
    { "Key 2", "Key 2" }
};

//Get the value of Dictionary

string val = dictionary["Key 1"];

try
{
    val = dictionary["Key 3"];
}
catch (Exception ex)
{
    Console.WriteLine("Error trying to get the value by Key 3");
    System.Console.WriteLine(ex.Message);
}
{

}
// Verify if Key exist before acess to dont came errors
if ( dictionary.ContainsKey("Key 2"))
{
    System.Console.WriteLine($"Key 2 ");
}

// Another way to get the value and dont get a error
dictionary.TryGetValue("Key 4", out string? valor);
if(valor is not null)
    System.Console.WriteLine($"Key 4: {valor}");

// We can add by the same way with inexistent Key
dictionary["Key 0"] = "Value 0";

// Run the dictionary
foreach(KeyValuePair<string, string> kvp in dictionary) //kvp = nome da variável
{
    System.Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

//Using Abstract Data Types with dicionary

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();
dicPessoa.Add(
    1,
    new Pessoa(){
        Id = 0,
        BirthDate = new DateTime(1984, 7, 5),
        Name = "Mauricio Roberto Gonzatto"
    }
);
dicPessoa.Add(
    2,
    new Pessoa(){
        Id = 1,
        BirthDate = new DateTime(1999, 8, 1),
        Name = "Maurijua Habilad Antat Uiu"
    }
);

foreach ( KeyValuePair<int, Pessoa> kvp in dicPessoa) 
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}