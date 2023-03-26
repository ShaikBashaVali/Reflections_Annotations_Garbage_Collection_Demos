using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class CustomerInfo : Object
    {
        int ID1 = -100;
        public int ID
        {
            get
            {
                if (ID > 0)
                    return ID;
                else
                    return 0;
            }
            set
            {
                if (value > 0)
                {
                    ID = value;
                }
            }
        }
        public string ClassName { get; set; }
        public int MyProperty { get; set; }
        public CustomerInfo(int id, string name)
        {
            this.ID = id;
            this.ClassName = name;
        }
        public CustomerInfo()
        {
            this.ID = -1;
            this.ClassName = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("id " + this.ID);
        }
        public void PrintName()
        {
            Console.WriteLine("id " + this.ClassName);
        }
    }
}







