using FluentAssertions;

using ProjectEuler.Helpers;
using ProjectEuler.Solving;

namespace ProjectEuler.Tests;

public class ProblemOne
{
    [Fact]
    public void GetMultiplesInCollection_NaturalNumbersBelowTenForMultiplesOfThreeAndFive_SumIsTwentyThree()
    {
        // Arrange
        var collection = IntegerSequenceGenerator.GenerateSequence(1, 9);

        var multiplesToCheck = new [] { 3, 5 };

        // Act
        var result = Multiples.GetMultiplesInCollection(collection, multiplesToCheck);

        // Assert
        result.Sum().Should().Be(23);
    }

    [Fact]
    public void GetMultiplesInCollection_NaturalNumbersBelowThousandForMultiplesOfThreeAndFive_SumIsTwentyThree()
    {
        // Arrange
        var collection = IntegerSequenceGenerator.GenerateSequence(1, 999);

        var multiplesToCheck = new[] { 3, 5 };

        // Act
        var result = Multiples.GetMultiplesInCollection(collection, multiplesToCheck);

        // Assert
        result.Sum().Should().Be(233168);
    }
}