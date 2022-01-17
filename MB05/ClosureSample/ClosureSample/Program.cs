using System;
using System.Linq;

namespace ClosureSample {

    public delegate int Operation(int value);

    class Program {
        static void Main(string[] args) {
            // Was gibt Main auf der Console aus und wieso?

            var ret = GetOperation();
            Console.WriteLine(ret.a(5));
            Console.WriteLine(ret.b(5));


            //var oper = GetOperation();
            //Console.WriteLine(oper(5));

            //var oper1 = GetOperation();
            //Console.WriteLine(oper1(5));

            //Console.WriteLine(oper(5));
            //Console.WriteLine(oper(5));
            //Console.WriteLine(oper(10));
            //Console.WriteLine(oper1(8));
        }


        public static (Operation a, Operation b) GetOperation() {
            int multiplier = 5;
            //Operation operation = x => x * multiplier++;
            //return operation;

            Operation operationA = delegate (int x) {
                Console.WriteLine("A wird ausgeführt");
                return x * multiplier++;
            };
            Operation operationB = delegate (int x) {
                Console.WriteLine("B wird ausgeführt");
                return x * multiplier++;
            };

            multiplier = 10;
            return (operationA, operationB);
        }
    }



}
