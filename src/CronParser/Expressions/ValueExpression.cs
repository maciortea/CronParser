using System;
using System.Collections.Generic;
using System.Text;

namespace CronParser.Expressions
{
    public class ValueExpression : Expression
    {
        private string _value;

        public ValueExpression(string value)
        {
            _value = value;
        }

        public override int[] Interpret(Context context)
        {
            return new int[] { int.Parse(_value) };
        }
    }
}
