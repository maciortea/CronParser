using System;
using System.Collections.Generic;
using System.Text;

namespace CronParser
{
    public class Context
    {
        public string Input { get; }
        public string Output { get; set; }

        public Context(string input)
        {
            Input = input;
        }
    }
}
