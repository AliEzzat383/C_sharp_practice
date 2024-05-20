
public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) 
    {
        IList<int> result = new List<int>();
        for(int i=0;i<words.Length;i++){
            if(words[i].Contains(x)){
                result.Add(i);
            }
        }
       return  result;
    }
}


public class Program{
     public static void Main()
    {
        string[] words = ["leet","code"];
        char x ='e';
        Solution p = new Solution();
        foreach(int i in p.FindWordsContaining(words,x)){
            Console.Write(i);
        }
        // Console.Write(p.FindWordsContaining(words,x));
    }
}