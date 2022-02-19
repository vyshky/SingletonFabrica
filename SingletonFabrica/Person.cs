using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SingletonFabrica
{
    [Serializable]
    public class Person : IClone
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Person() { }
        public Person(Person person)
        {
            Id = person.Id;
            Name = person.Name;
        }

        public IClone Clone()
        {
            return new Person(this);
        }

        public IClone SuperClone()
        {
            Person clone;
            MemoryStream memoryStream = new MemoryStream();
            StreamingContext streamingContext = new StreamingContext(StreamingContextStates.Clone);
            BinaryFormatter binaryFormatter = new BinaryFormatter(null, streamingContext);
            binaryFormatter.Serialize(memoryStream, this);
            memoryStream.Seek(0, SeekOrigin.Begin);
            clone = (Person)binaryFormatter.Deserialize(memoryStream);
            return clone;
        }


        public string Say()
        {
            return $"Меня зовут {Name} , мой идентификационный номер {Id}";
        }
    }
}
