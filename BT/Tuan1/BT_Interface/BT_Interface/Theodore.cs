﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Interface
{
    class Theodore : IHuman
    {
        private string m_Name;
        public void Speak(string Message)
        {
            Console.WriteLine("Hi my name is " + m_Name);
            Console.WriteLine(Message);

        }
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }
    }
}
