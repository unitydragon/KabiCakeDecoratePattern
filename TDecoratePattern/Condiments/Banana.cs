namespace CakeDecoratePattern.Condiments
{
    public class Banana : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Banana(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",香蕉";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 30;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
