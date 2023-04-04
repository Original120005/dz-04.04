using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz04_04
{
    interface IElement
    {
        void Accept(IVisitor visitor);
    }

    class ConcreteElemHouse : IElement
    {
        public string MethodHouse()
        {
            return "House";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitHouse(this);
        }
    }
    class ConcreteElemFabrik : IElement
    {
        public string MethodFabrik()
        {
            return "Fabrik";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitFabrik(this);
        }
    }
    class ConcreteElemBank : IElement
    {
        public string MethodBank()
        {
            return "Bank";
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitBank(this);
        }
    }


    interface IVisitor
    {
        void VisitHouse(ConcreteElemHouse element);
        void VisitFabrik(ConcreteElemFabrik element);
        void VisitBank(ConcreteElemBank element);
    }

    class ConcreteVisitorHouse : IVisitor
    {
        public void VisitHouse(ConcreteElemHouse element)
        {
            Console.WriteLine(element.MethodHouse() + " + ConcreteVisitor1");
        }
        public void VisitFabrik(ConcreteElemFabrik element)
        {
            Console.WriteLine(element.MethodFabrik() + " + ConcreteVisitor1");
        }
        public void VisitBank(ConcreteElemBank element)
        {
            Console.WriteLine(element.MethodBank() + " + ConcreteVisitor1");
        }
    }
    class ConcreteVisitorFabrik : IVisitor
    {
        public void VisitHouse(ConcreteElemHouse element)
        {
            Console.WriteLine(element.MethodHouse() + " + ConcreteVisitor1");
        }
        public void VisitFabrik(ConcreteElemFabrik element)
        {
            Console.WriteLine(element.MethodFabrik() + " + ConcreteVisitor1");
        }
        public void VisitBank(ConcreteElemBank element)
        {
            Console.WriteLine(element.MethodBank() + " + ConcreteVisitor1");
        }
    }
    class ConcreteVisitorBank : IVisitor
    {
        public void VisitHouse(ConcreteElemHouse element)
        {
            Console.WriteLine(element.MethodHouse() + " + ConcreteVisitor1");
        }
        public void VisitFabrik(ConcreteElemFabrik element)
        {
            Console.WriteLine(element.MethodFabrik() + " + ConcreteVisitor1");
        }
        public void VisitBank(ConcreteElemBank element)
        {
            Console.WriteLine(element.MethodBank() + " + ConcreteVisitor1");
        }
    }


    class Client
    {
        public static void ClientCode(List<IElement> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}