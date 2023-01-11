using System.Threading;
using Xunit;

namespace Refactoring.Tests;

public class FibonacciTest
{
    [Fact]
    public void TestFirstFibonacciNumberIsOne()
    {
        int n = 1;
        int expected = 1;

        int actual = Fibonacci.Fib(n);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestBigFibonacciNumber()
    {
        // Arrange
        int n = 45;
        int expected = 1134903170;

        // Act
        int actual = Fibonacci.Fib(n);

        // Assert
        Assert.Equal(expected, actual);
    }
}