namespace _04_LSP.Good
{
    internal class Worker : IWorker, IEat
    {
        public void Eat()
        {
            // yemek yiyebilir.
        }

        public void Work()
        {
            // calisabilir.
        }
    }
}
// Isp olacak
