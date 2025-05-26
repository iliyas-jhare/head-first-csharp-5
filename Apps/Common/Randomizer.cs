namespace Common;

public static class Randomizer<T>
{
    public static T[] GetRandomItems(T[] source, int count)
    {
        // normalize the count
        count = count <= 0 || count > source.Length ? source.Length : count;

        // collect random items
        List<T> list = source.ToList();
        T[] instances = new T[count];
        for (int i = 0; i < count; i++)
        {
            int index = Random.Shared.Next(list.Count);
            instances.SetValue(list[index], i);
            list.RemoveAt(index);
        }

        // return items
        return instances;
    }
}
