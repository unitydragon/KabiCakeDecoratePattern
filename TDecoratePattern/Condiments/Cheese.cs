namespace CakeDecoratePattern.Condiments
{
    public class Cheese : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Cheese(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",起司";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 20;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
