string greeting = "     Hello, World!     ";
Console.WriteLine($"{greeting}");

//Metódo "Trim" remove todos os espaços vazios do início e fim da string
string trimmedgreeting = greeting.Trim();
Console.WriteLine($"{trimmedgreeting}");

//Metódo "TrimStart" remove todos os espaços vazios do início da string
trimmedgreeting = greeting.TrimStart(' ');
Console.WriteLine($"{trimmedgreeting}");

//Metódo "TrimEnd" remove todos os espaços vazios do fim da String
trimmedgreeting = greeting.TrimEnd(' ');
Console.WriteLine($"{trimmedgreeting}");