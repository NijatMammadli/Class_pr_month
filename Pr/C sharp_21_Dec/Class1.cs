using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public static class RemoveBannedWords       
    {
        public static string RemoveBannedWords_2(this string s, string[] bannedWords)
        {
            
                
                foreach(var elem in bannedWords)
            {
               s = s.Replace(elem, "");
            }
            return s; 
                
        }
    }
}
