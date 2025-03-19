public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int rows= image.Length;
        int columns = image[0].Length;
        var  stack = new Stack<(int,int)>();

        int originalColor= image[sr][sc];

        if(color == originalColor)
        return image;


        stack.Push((sr, sc));

        while(true)
        {
            if(stack.Count == 0)
            {
                break;
            }
            var (i,j) = stack.Pop();

            if(image[i][j] != originalColor)
            {
                continue;
            }

            image[i][j] = color;

            if(i-1 >=0)
            {
                stack.Push((i-1,j));
            }

            if(i+1 < rows)
            {
                stack.Push((i+1,j));
            }

            if(j-1 >=0)
            {
                stack.Push((i,j-1));
            }

            if(j+1 <columns)
            {
                stack.Push((i,j+1));
            }
        }

        return image;
    }
} 