namespace APIExperiment
{
    public class FakeDB
    {
        private readonly string[] names = ["Lukas", "Tobias", "Signe", "Kristian", "Lasse", "Sofie"];

        public Customer GetRandomCustomer()
        {
            return new Customer(
                Random.Shared.Next(10000),
                names[Random.Shared.Next(names.Length)],
                Random.Shared.Next(100),
                Random.Shared.Next(10000000, 100000000).ToString()
            );
        }
    }
}
