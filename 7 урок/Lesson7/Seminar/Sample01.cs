using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar
{

    public partial class MySample
    {

        public int A { get; set; }

    }

    internal class Sample01
    {
        static void Main(string[] args)
        {
            MySample sample = new MySample();
            sample.A = 12;
            sample.B = 13;
        }
    }
}
