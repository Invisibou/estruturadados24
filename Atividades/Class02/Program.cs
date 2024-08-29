using Class02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1
    = new Person("Marcos Vermolhen", 19);
Console.WriteLine(person1.Name);

Person person2 = new ();
person2.Name = "Vladmir Putin";
person2.Age = 55;
Console.WriteLine(person2.Name);

Person person3 = new Person()
{
    Name = "Leonel Messi",
    Age = 40
};

Console.WriteLine(person3.Name);
//int e string não seriam tipos primitivos? O professor disse que são tipos abstratos de dados.