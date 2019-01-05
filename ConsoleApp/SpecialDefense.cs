namespace ConsoleApp
{
    public abstract class SpecialDefense
    {
        public abstract int CalculateDamageReduction(int totalDamage);

        public static SpecialDefense Null { get; private set; } = new NullDefense();

        private class NullDefense : SpecialDefense
        {
            public override int CalculateDamageReduction(int totalDamage) => 0;
        }
    }
}