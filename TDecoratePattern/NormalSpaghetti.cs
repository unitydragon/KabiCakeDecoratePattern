using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CakeDecoratePattern
{
    public class NormalSpaghetti : Spaghetti
    {
        public override string GetName()
        {
            return "平民義大利麵";
        }

        public override string GetDescription()
        {
            return "義大利細麵";
        }

        public override int GetPrice()
        {
            return 100;
        }
    }
}
