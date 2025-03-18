public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>(); 

        var len = s.Length;

        if(len%2 ==1)
        return false;

        foreach(var c in s)
        {
            if(c=='(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if(stack.Count ==0) return false;

                var top = stack.Pop();

                if((top=='(' && c!= ')') ||
                (top=='{' && c!= '}') ||
                (top=='[' && c!= ']') )
                {
                    return false;
                }

            }
        }

        return stack.Count == 0 ;
    }
}
