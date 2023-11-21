namespace FakePerson.lib;

public static class RandomExtensions
{
    public static string NextString(this Random random, IEnumerable<string> source)
    {
        var list = source.ToList();
        var i = random.Next(0, list.Count);
        
        return list[i];
    }
}