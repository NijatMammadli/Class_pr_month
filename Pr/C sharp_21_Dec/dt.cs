using System;
using System.Collections.Generic;
using System.Text;

namespace Methods   
{
    public static class dt
    {
        public static int GetHoursDifference(this DateTime dt, DateTime today)
        {
             
                
            return (dt - today).Hours;
            
        }
    }
}
