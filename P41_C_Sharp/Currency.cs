
namespace P41_C_Sharp
{
    internal class Currency : IOutput
    {
        private string v1;
        private decimal v2;
        private int v3;

        public Currency(string v1, decimal v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public void Show()
        {
            Console.WriteLine($"v1 - {v1}, v2 - {v2}, v3 - {v3}");
        }

        public void Show(string info)
        {
            Console.WriteLine($"{info} : v1 - {v1}, v2 - {v2}, v3 - {v3}");
        }

        public static implicit operator decimal(Currency v)
        {
            throw new NotImplementedException();
        }
    }
}