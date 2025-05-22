using System.Text;

using CardPickerApp;

Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine($"Started. {DateTime.Now:F}");

while (true)
{
    Console.WriteLine("Enter the number of cards: ");
    string? input = Console.ReadLine();
    if (string.Equals("Q", input, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Quit app requested...");
        break;
    }

    if (string.IsNullOrEmpty(input) || int.TryParse(input, out int count) is false)
    {
        Console.WriteLine("Invalid number of cards entered.");
        continue;
    }

    foreach (Card card in CardPicker.GetCards(count))
    {
        Console.WriteLine($"Card: {card}");
    }
    Console.WriteLine();
}

Console.WriteLine($"Finished. {DateTime.Now:F}");
Console.ReadKey();

