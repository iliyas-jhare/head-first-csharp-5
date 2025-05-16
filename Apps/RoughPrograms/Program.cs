
TimesInnerOuterLoopsIterated();

static void TimesInnerOuterLoopsIterated()
{
    Console.WriteLine("Started.");
    int p = 2;
    int outerCount = 0;
    int innerCount = 0;
    for (int q = 2; q < 32; q *= 2)
    {
        while (p < q)
        {
            // How many times will the next statement be executed?
            p = p * 2;
            Console.WriteLine($"p={p}");
            innerCount++;
        }

        q = p - q;
        Console.WriteLine($"q={q}");
        outerCount++;
    }

    Console.WriteLine($"Outer loop iterated: {outerCount}");
    Console.WriteLine($"Inner loop iterated: {innerCount}");
    Console.WriteLine("Finished.");
}