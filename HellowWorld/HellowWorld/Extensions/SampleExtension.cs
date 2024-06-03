using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld.Extensions
{
    public static class SampleExtension
    {
        public static int? TryParseInt(this string value)
        {
            if(int.TryParse(value,out  int result))
            {
                return result;
            }else { return null; }
        }
    }
}
