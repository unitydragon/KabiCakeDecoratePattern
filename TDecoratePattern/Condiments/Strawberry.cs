namespace CakeDecoratePattern.Condiments
{
    public class Strawberry : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Strawberry(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",草莓";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 50;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
