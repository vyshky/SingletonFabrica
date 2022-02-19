using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFabrica
{
    public class Clone : Person, ICloning
    {
        private static int count = 0;
        private static Clone _clone;
        private Clone()
        {
            Name = "Клон";
            Id = count;
        }
        public static Clone GetClone()
        {
            if (_clone == null)
            {
                return _clone = new Clone();
            }
            ++count;
            return _clone;
        }
    }
}
