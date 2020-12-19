using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesandIndexesApp
{
    class Calculate
    {
        int AccountBalance = 25600;

        //Readwrite Property
        public int balance
        {
            get { return AccountBalance; } //getter Method [For Reading]
            set { AccountBalance = value; } //setter Method [For Writing]
        }

        public int readBalance
        {
            get { return AccountBalance; }
        }

        public int writeBalance
        {
            set { AccountBalance = value; }
        }

        //Auto Implemented property
        public string name { get; set; }

        //Auto Implemented Property Read Only
        public string readName { get; private set; }

        //Auto Implemented Property Write Only
        public string writeName { private get; set; }
    }
}
