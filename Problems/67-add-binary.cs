public class Solution {
    public string AddBinary(string a, string b) {
        int lena = a.Length;
        int lenb = b.Length;

        int counter = -1;
        int remainder = 0;

         int flaga = 0;
         int flagb = 0;

        a= Reverse(a);
        b= Reverse(b);
         StringBuilder sb = new StringBuilder();
        while (true)
        {
            counter ++;


            if(counter > (lena-1) && counter > (lenb -1) && remainder ==0)
            {
                break;
            }
            if(counter > (lena -1))
            {
                flaga = 0;
            }
            else
            {
                flaga = int.Parse(a[counter].ToString());
            }

                        if(counter > (lenb - 1))
            {
                flagb = 0;
            }
            else
            {
                flagb = int.Parse(b[counter].ToString());
            }

            var sum = remainder + flaga + flagb;
            sb.Append((sum%2).ToString());

            Console.WriteLine("flaga:" + flaga);
            Console.WriteLine("flagb:" + flagb);
            Console.WriteLine(sb.ToString());

            remainder = (sum >= 2) ? 1 : 0;
        }

         return Reverse(sb.ToString());
    }

    private string Reverse(string s)
    {
        var r = new StringBuilder();

                 for (int i = s.Length -1; i>=0; i--)
         {
            r.Append(s[i]);
         }

          return r.ToString();
    }
}