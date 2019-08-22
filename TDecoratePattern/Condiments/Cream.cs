namespace CakeDecoratePattern.Condiments
{
    public class Cream : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Cream(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",奶油";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 25;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
