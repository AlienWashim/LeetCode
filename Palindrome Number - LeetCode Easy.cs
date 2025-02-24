public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false;

        int copy = x;
        int newNumber = 0;
        
        while(x > 0){
            int lastDigit = x % 10;
            newNumber = newNumber*10 + lastDigit;
            x /= 10;
        }

        return copy == newNumber;
    }
}
