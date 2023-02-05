namespace ProjectEuler.Helpers;

public class IntegerSequenceGenerator
{
    public static IReadOnlyList<int> GenerateSequence(int startValue, int maximumValue)
    {
        return Enumerable.Range(startValue, maximumValue).ToList();
    }
}
