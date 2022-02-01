using ComomMistakes;

Console.WriteLine("Hello, World!");

var menu = 0;

do
{
    Console.WriteLine(@"
    Select a Mnue option:
    0 - Exit;
    1 - Test Unhandled Error.
    2 - Test false task.Wait().    
    3 - Test false task.GetAwaiter().GetResult();    
    4 - Test async task.Wait();    
    5 - Test async task.GetAwaiter().GetResult();
    ");

    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            new UnhandledError().DivisaoPorZero();
            break;
        case 2:
            new FalseTask().CallFalseTask().Wait();
            break;
        case 3:
            new FalseTask().CallFalseTask().GetAwaiter().GetResult();
            break;
        case 4:
            new AsyncTask().CallTask().Wait();
            break;
        case 5:
            new AsyncTask().CallTask().GetAwaiter().GetResult();
            break;
        default: break;
    }


} while (menu != 0);
