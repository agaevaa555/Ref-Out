namespace TaskRefOut
{

    class Program
    {

        static void Main(string[] args)
        {
            Person newPerson = new Person();
            newPerson.Age = 20;
            newPerson.ID = 52;
            newPerson.Name = "aytac";
            Modify(newPerson);
            Console.WriteLine(newPerson.Age);
            Mod(out newPerson);
            Console.WriteLine(newPerson.Name);
            Mody(ref newPerson);
            Console.WriteLine(newPerson.ID);
            static void Modify(Person newPerson)
            {
                newPerson.Age = 30;
            }
            static void Mod(out Person newPerson)
            {
                newPerson = new Person();
                newPerson.Name = " emilia";
            }
            static void Mody(ref Person newPerson)
            {
                newPerson = new Person();
                newPerson.ID = 8;
            }
        }
        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public int ID { get; set; }
        }
    }
}
