using ArvoreBinariaCargos;

Tree<Person> company = new Tree<Person>();
company.Root = new Node<Person>()
{
    Data = new Person(1, "Marcos Vermolhen", "Conselheiro"),
    Parent = null
};

company.Root.Children = new List<Node<Person>>()
{
    new Node<Person>
    {
        Data = new Person(2, "Michael Jackson", "Rei do pop"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(3, "Michael Jordan", "Rei do Baska"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(4, "GTA SAN ANDREAS", "Rei dos jogos"),
        Parent = company.Root
    },
};
company.Root.Children[0].Children = new List<Node<Person>>()
{ 
    new Node<Person>
    {
        Data = new Person(5, "Douglas Guimarães", "Rei da Matemática"),
        Parent = company.Root
    },

    new Node<Person>
    {
        Data = new Person(7, "Stephen Hawking", "Rei da Física"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(9, "Elon Musk", "Rei da tecnologia"),
        Parent = company.Root
    }
};
company.Root.Children[1].Children = new List<Node<Person>>()
{
    new Node<Person>
    {
        Data = new Person(6, "PI", "Rei dos círculos"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(8, "Professores", "Rei do ensino"),
        Parent = company.Root
    },
    new Node<Person>
    {
        Data = new Person(11, "Ayrton Senna", "Rei das pistas"),
        Parent = company.Root
    }
};
company.Root.Children[2].Children = new List<Node<Person>>()
{
    new Node<Person>
    {
        Data = new Person(10, "Naruto", "Rei dos animes"),
        Parent = company.Root
    }
};


company.PrintTree(company.Root);