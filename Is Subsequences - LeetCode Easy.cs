public class Solution {
    public bool IsSubsequence(string s, string t) {
        int index = 0;
        
        foreach (char c in s) {
            bool found = false;
            
            while (index < t.Length) {
                if (t[index] == c) {
                    found = true;
                    index++;
                    break;
                }
                index++;
            }
            
            if (!found) return false;
        }

        return true;
    }
}
