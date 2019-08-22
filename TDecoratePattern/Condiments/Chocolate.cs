namespace CakeDecoratePattern.Condiments
{
    public class Chocolate : CondimentDecorator
    {
        private readonly Spaghetti _spaghetti;

        public Chocolate(Spaghetti pSpaghetti)
        {
            this._spaghetti = pSpaghetti;
        }

        public override string GetDescription()
        {
            return _spaghetti.GetDescription() + ",巧克力";
        }

        public override int GetPrice()
        {
            return _spaghetti.GetPrice() + 38;
        }

        public override string GetName()
        {
            return _spaghetti.GetName();
        }
    }
}
