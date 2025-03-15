public class Solution {
    public string Convert(string s, int numRows) {
        
        if(numRows ==1)
        {
            return s;
        }

        int filler = numRows - 2;
        int len = s.Length;

        var map = new char[5000, 5000 + 1];
      
for (int i = 0; i < numRows; i++)
    for (int j = 0; j < map.GetLength(1); j++)
        map[i, j] = ' ';

        var remainingChars=len;

        int columnCounter = 0;



        while(true)
        {
            if(s.Length==0)
            {
                break;
            }

            var remaining = s.Length;

            var take= Math.Min(remaining,numRows);
            var firstPart= s.Substring(0, take);
            Zig(firstPart, columnCounter, map);
            columnCounter++;
            s=s.Remove(0, take);



       
            if(s.Length==0)
            {
                break;
            }


            remaining = s.Length;

            take= Math.Min(remaining,filler);

            var secondPart= s.Substring(0, take);

             s=s.Remove(0, take);
              Zag(secondPart, columnCounter, map,numRows);
             columnCounter+=filler;
        }


        string result = string.Empty;

        // for(int i=0;i<numRows;i++)
        // {
        //     for(int j=0;j<25;j++)
        //      {
        //          Console.Write(map[i,j]);
        //      }
        //     Console.WriteLine();
        //  }


        for(int i=0;i<numRows;i++)
        {
            for(int j=0;j<5000;j++)
            {
                if (char.IsLetter(map[i, j]) || map[i, j] == '.' || map[i, j] == ',')
                {
                    result += map[i,j];
                }
            }
        }

        return result;

    }

        private void Zig(string s,int columnId, char[,] map)
        {
            //  Console.WriteLine("Zig s: " + s);
            //  Console.WriteLine("columnId " + columnId);
            if(string.IsNullOrEmpty(s))
            {
                return;
            }

            for(int i=0;i<s.Length;i++)
            {

                map[i,columnId]= s[i];
            }
        }


        private void Zag(string s,int columnId, char[,] map, int numRows)
        {
            // Console.WriteLine("Zag s: " + s);
            for(int i=0;i<s.Length;i++)
            {
                // Console.WriteLine("columnId " + columnId);
                var some = numRows-2-i;
                 Console.WriteLine("umRows-2-i " + some);
                 Console.WriteLine("columnId " + columnId);
                map[numRows-2-i,columnId]= s[i];
                columnId++;
            }
        }
}