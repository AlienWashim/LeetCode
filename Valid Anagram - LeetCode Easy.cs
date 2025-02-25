public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length){
            return false;
        }

        if (s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c))){
            return true;
        }

        return false;
    }
}
