namespace CakeDecoratePattern.Condiments
{
    public class Egg : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Egg(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",蛋";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 5;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
