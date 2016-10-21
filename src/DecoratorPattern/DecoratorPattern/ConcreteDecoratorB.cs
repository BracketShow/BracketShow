using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
            
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreateDecoratorB.Opeartion()");
        }

        void AddedBehavior()
        {
            
        }
    }
}