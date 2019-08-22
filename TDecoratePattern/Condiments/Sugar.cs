namespace CakeDecoratePattern.Condiments
{
    public class Sugar : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Sugar(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",糖";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 12;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
