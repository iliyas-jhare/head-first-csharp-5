namespace MatchAnimals;

public static class Emojis
{
    public static string[] Animals =>
    [
        "🐶", "🐱", "🐭", "🐹", "🐰", "🐸", "🐯", "🐨", "🐻", "🐼", "🐷",
        "🐵", "🐔", "🐧", "🐦", "🐤", "🐣", "🦆", "🦢", "🦉", "🦇", "🦄",
        "🐴", "🦘", "🦡", "🦑", "🐙", "🐚", "🐠", "🐟", "🐡", "🦈", "🐬",
        "🐳", "🐋", "🦓", "🦒", "🐘", "🦣", "🦏", "🦛", "🦍", "🦧", "🐪",
        "🐫", "🦙", "🦞", "🦐", "🐍", "🦎", "🐢", "🦕", "🦖", "🐉"
    ];

    public static string[] GetAnimalEmojis(int count)
    {
        // make sure count is not greater than the animal emojis collection
        count = count > Animals.Length ? Animals.Length : count;

        List<string> items = [];
        List<string> emojis = Animals.ToList();
        for (int i = 0; i < count; i++)
        {
            int index = Random.Shared.Next(emojis.Count);
            items.Add(emojis[index]);
            emojis.RemoveAt(index);
        }

        return items.ToArray();
    }
}