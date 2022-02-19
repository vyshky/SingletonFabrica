using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFabrica
{
    public class Factory
    {
        public List<ICloning> _clones;

        public Factory(List<ICloning> clones)
        {
            _clones = clones;
        }

        public ICloning GetClone(int num)
        {
            switch (num)
            {
                case 1: return Clone.GetClone(); break;
                case 2: return Clone.GetClone(); break;
                case 3: return Clone.GetClone(); break;
                case 4: return Clone.GetClone(); break;
            }
            return null;
        }
    }
}
