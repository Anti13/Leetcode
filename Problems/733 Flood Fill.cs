public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        int rows= image.Length;
        int columns = image[0].Length;
        var  stack = new Stack<(int,int)>();

        int originalColor= image[sr][sc];

        if(color == originalColor)
        return image;

        var visited = new bool[rows, columns];

        stack.Push((sr, sc));

        while(true)
        {
            if(stack.Count == 0)
            {
                break;
            }
            var (i,j) = stack.Pop();

            if(visited[i,j])
            {
                continue;
            }

            visited[i,j] = true;
            
            if(image[i][j] == originalColor)
            {
                image[i][j] = color;
            }
            else{
                continue;
            }

            if(i-1 >=0 && !visited[i-1,j])
            {
                stack.Push((i-1,j));
            }

            if(i+1 < rows && !visited[i+1,j])
            {
                stack.Push((i+1,j));
            }

            if(j-1 >=0 && !visited[i,j-1])
            {
                stack.Push((i,j-1));
            }

            if(j+1 <columns && !visited[i,j+1])
            {
                stack.Push((i,j+1));
            }
        }

        return image;
    }
} 