using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo {
    class Program {
        static void Main(string[] args) {
            MyClass mc = new MyClass();
            mc.Test1();
            mc.Test2();


            MyClassPartielleMethoden mcpm = new MyClassPartielleMethoden();
            mc.Test1();
            mc.Test2();
        }
    }
}
