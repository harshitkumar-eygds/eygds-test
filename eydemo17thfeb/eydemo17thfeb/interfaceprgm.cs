using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eydemo17thfeb
{
    interface Imyinterface 
    {
        void add();
        void remove();
    }

    interface Inewinterface
    {
        void clear();
    }

    class myclass : Imyinterface, Inewinterface   //implementation
    {
        public void add()
        {
            Console.WriteLine("this is add function of Imyinterface");
        }

        public void clear()
        {
            Console.WriteLine("this is clear function of Inewinterface");
        }

        public void remove()
        {
            Console.WriteLine("this is remove function of Imyinterface");
        }
    }

    class interfaceprgm 
    {
        static void Main(string[] args)
        {
            myclass obj1 = new myclass();
            obj1.add();
            obj1.clear();
            obj1.remove();
        }
    }
}
