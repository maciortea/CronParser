using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CronParser.Expressions.Operators
{
    public class AsteriskExpression : Expression
    {
        private readonly int[] _possibleValues;

        public AsteriskExpression(int[] possibleValues)
        {
            _possibleValues = possibleValues;
        }

        public override int[] Interpret(Context context)
        {
            return _possibleValues;
        }
    }
}
