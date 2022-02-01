namespace ComomMistakes
{
    public class UnhandledError
    {
        public int Id { get; set; } = 0;
        public void DivisaoPorZero()
        {
            var i = 2 / Id;
        }
    }
}
