namespace Refactoring;

public class Fibonacci
{
    public static int Fib(int n){
        int fibonacciResult = n;
        if (n < 0) {
            throw new ArgumentException("Fibonacci undefined for negative numbers");
        } else if (n > 1) {
            fibonacciResult = Fib(n - 2) + Fib(n - 1);
        }
        return fibonacciResult;
    }
}