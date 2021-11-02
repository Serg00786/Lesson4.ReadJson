using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadThreeDifferentJsonStructure
{
    public interface IReadJson1
    {
        void Read(string json1);
    }
    public class ReadJson1 : IReadJson1
    {
        public void Read(string json1)
        {
            Console.WriteLine(json1);
        }
    }
}
