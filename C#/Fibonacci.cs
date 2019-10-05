public static class FibonacciHelper
{
    public static int Fibonacci(int n)
    {
        if (n <= 0) {
            return 0;
        }

        if (n == 1) {
            return n;
        }

        return Fibonacci(n-1) + Fibonacci(n-2);
    }
}