public class Solution {
    public bool IsPalindrome(string s) {
        char[] charArray = new char[s.Length];
        int i = 0;
        foreach (char c in s){
            if((c >= 'a' && c <= 'z') || (c >= '0' && c <= '9')){
                charArray[i++] = c;
            }
            else if(c >= 'A' && c <= 'Z'){
                charArray[i++] = (char) (c + 32);
            }
        }

        char[] filteredArray = new char[i];
        Array.Copy(charArray, filteredArray, i);

       char[] reversedArray = new char[i];
        Array.Copy(filteredArray, reversedArray, i);
        Array.Reverse(reversedArray);

        return new string(filteredArray) == new string(reversedArray);
    }
}
