namespace ProjectEuler.Solving;

public class Multiples
{
    public static IReadOnlyList<int> GetMultiplesInCollection(
        IReadOnlyList<int> collection,
        params int[] multiplesToCheck)
    {
        return collection
            .Where(n => multiplesToCheck.FirstOrDefault(m => n % m == 0) != default)
            .ToList();
    }
}
