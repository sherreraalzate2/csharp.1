namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateCoverted = new DateOnly();
            string nameinput;
            string birthdayInput;
            Console.WriteLine($"Hola Bienvenido al calculador de años!");
            Console.WriteLine($"Escribe tu nombre: ");
            nameinput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameinput}");
            Console.WriteLine($"Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdayInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdayInput, out dateCoverted);
            if (isDateValid == false) Console.WriteLine($"La fecha de nacimiento es invalida usted nos envio este dato erroneo {birthdayInput}");
            var person = new Person
            {
                Name = nameinput,
                Birthday = dateCoverted,
                Age = DateTime.Now.Year - dateCoverted.Year
            };


            Console.WriteLine($"Tu nombre: {person.Name} ");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday} ");
            Console.WriteLine($"Tu edad es: {person.Age} años ");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly Birthday { get; set; }
    }

}





