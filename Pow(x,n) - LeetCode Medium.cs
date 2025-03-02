public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1;

        if (n < 0) {
            x = 1 / x;
            if (n == int.MinValue) {
                n++;
                return x * MyPow(x, -n);
            }
            n = -n;
        }

        double half = MyPow(x, n / 2);
        return (n % 2 == 0) ? half * half : half * half * x;
    }
}
