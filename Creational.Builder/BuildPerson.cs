namespace Creational.Builder
{
    public class Person
    {
        private Person()
        {

        }
        private string name;
        private int age;
        private int id;
        public string Name => name;
        public int Age => age;
        public int Id { get { return id; } }

        public class PersonBuilder
        {
            private Person person;
            public PersonBuilder()
            {
                person = new Person();
            }
            public PersonBuilder SetName(string name)
            {
                person.name = name;
                return this;
            }
            public PersonBuilder SetAge(int age)
            {
                person.age = age;
                return this;
            }
            public PersonBuilder SetId(int id)
            {
                person.id = id;
                return this;
            }
            public Person Build()
            {
                return person;
            }
        }
    }
}