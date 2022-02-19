using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFabrica
{
    public interface IClone
    {
        public IClone Clone();
        public IClone SuperClone();
        public string Say();
    }
}
