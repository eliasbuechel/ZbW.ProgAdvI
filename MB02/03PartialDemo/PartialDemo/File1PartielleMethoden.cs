using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo {
    partial class MyClassPartielleMethoden {
        public void Test1() {
            Test1Initialize();
            /* ... */
            Test1Cleanup();
        }

        partial void Test1Initialize();
        partial void Test1Cleanup();
    }
}
