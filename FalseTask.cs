namespace ComomMistakes
{
    public class FalseTask
    {
        public Task CallFalseTask()
        {
            try
            {
                Task.Run(() =>
                {
                    try
                    {
                        new UnhandledError().DivisaoPorZero();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro tratado dentro da Task " + e.Message);
                        throw;
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro tratado fora da Task " + e.Message);
            }
            return Task.CompletedTask;
        }
    }
}
