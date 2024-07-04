namespace APIExperiment
{
    public class Customer(int id, string name, int age, string phone)
    {
        public int ID { get; init; } = id;
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public string Phone { get; set; } = phone;
    }
}
