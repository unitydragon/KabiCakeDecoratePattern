namespace CakeDecoratePattern
{
    public class Bacon : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Bacon(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",培根";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 40;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
