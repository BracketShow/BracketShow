using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = new ConcreteComponent();
            var decoratorA = new ConcreteDecoratorA(component);
            var decoratorB = new ConcreteDecoratorB(decoratorA);

            decoratorB.Operation();

            Console.ReadKey();
        }
    }
}
