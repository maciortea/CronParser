using CronParser.Expressions.Operators;
using System.Collections.Generic;
using System.Linq;

namespace CronParser.Expressions
{
    public abstract class ExpressionCore : Expression
    {
        public const string SlashOperator = "/";
        public const string AsteriskOperator = "*";
        public const string CommaOperator = ",";
        public const string RangeOperator = "-";

        public string Name { get; }

        public ExpressionCore(string name)
        {
            Name = name;
        }

        public abstract int[] GetPossibleValues();

        public override int[] Interpret(Context context)
        {
            Expression expression = CreateExpression(context);
            return expression.Interpret(context);
        }

        private Expression CreateExpression(Context context)
        {
            if (context.Input.Contains(SlashOperator))
            {
                string[] inputs = context.Input.Split(SlashOperator);
                string leftInput = inputs[0];
                string rightInput = inputs[1];
                Expression leftExpression = CreateExpression(new Context(leftInput));
                Expression rightExpression = new ValueExpression(rightInput);
                return new SlashExpression(leftExpression, rightExpression);
            }

            if (context.Input.Contains(AsteriskOperator))
            {
                return new AsteriskExpression(GetPossibleValues());
            }

            if (context.Input.Contains(CommaOperator))
            {
                return CreateCommaExpression(context.Input);
            }

            if (context.Input.Contains(RangeOperator))
            {
                return CreateRangeExpression(context.Input);
            }

            return new ValueExpression(context.Input);
        }

        private Expression CreateCommaExpression(string input)
        {
            IEnumerable<Expression> valueExpressions = input.Split(CommaOperator).Select(v => new ValueExpression(v));
            return new CommaExpression(valueExpressions);
        }

        private Expression CreateRangeExpression(string input)
        {
            List<ValueExpression> valueExpressions = input.Split(RangeOperator).Select(v => new ValueExpression(v)).ToList();
            return new RangeExpression(valueExpressions[0], valueExpressions[1]);
        }
    }
}
