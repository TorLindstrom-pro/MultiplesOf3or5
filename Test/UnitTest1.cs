using MultiplesOf3or5;

namespace Test;

public class Tests
{
    [Test]
    public void NegativeInput_ReturnsZero()
    {
        var result = Kata.Solution(-1);
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test]
    public void OneMultiplePresent_ReturnsMultiple()
    {
        var result = Kata.Solution(5);
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Theory]
    [TestCase(6, 8)]
    [TestCase(10, 23)]
    [TestCase(20, 78)]
    public void MultipleMultiplesBelowInput_ReturnsSumOfMultiples(int input, int expected)
    {
        var result = Kata.Solution(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}