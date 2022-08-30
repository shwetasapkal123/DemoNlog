using System;
using System.Collections.Generic;
using System.Text;

namespace NlogDemo
{
    public class Sum
    {
        Nlog obj = new Nlog();

        public void Add(int a, int b)
        {
            if(a==0 || b==0)
            {
                obj.LogError("The a and b value is zero");
            }
            else
            {
                obj.LogDebug("The debugging");
            }
        }
    }
}
