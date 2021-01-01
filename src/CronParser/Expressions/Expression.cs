namespace CronParser.Expressions
{
    public abstract class Expression
    {
        public abstract int[] Interpret(Context context);
    }
}
