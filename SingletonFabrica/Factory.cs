using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SingletonFabrica
{
    public class FactoryClones
    {
        private static FactoryClones _instance;
        private FactoryClones()
        { }

        public static FactoryClones GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FactoryClones();
            }
            return _instance;
        }

        public string Say(IClone @interface)
        {
            return @interface.Say();
        }

    }
}
