using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CakeDecoratePattern.Condiments;

namespace CakeDecoratePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----義大利餐館菜單----");

            Spaghetti normalSpaghetti = new NormalSpaghetti(); // 產生平民義大利麵
            normalSpaghetti = new Chocolate(normalSpaghetti); // 加點火腿
            normalSpaghetti = new Egg(normalSpaghetti); // 加點蛋
            normalSpaghetti = new Cheese(normalSpaghetti); // 加點起司
            normalSpaghetti = new Bacon(normalSpaghetti); //
            Console.WriteLine("名稱:{0} 價錢:{1} 材料:{2}", 
                normalSpaghetti.GetName(), 
                normalSpaghetti.GetPrice(), 
                normalSpaghetti.GetDescription());

            Spaghetti spaghettiBolognese = new SpaghettiBolognese(); // 產生茄汁肉醬義大利麵
            spaghettiBolognese = new Strawberry(spaghettiBolognese);
            spaghettiBolognese = new Banana(spaghettiBolognese);
            spaghettiBolognese = new Sugar(spaghettiBolognese);
            Console.WriteLine("名稱:{0} 價錢:{1} 材料:{2}",
                spaghettiBolognese.GetName(), 
                spaghettiBolognese.GetPrice(), 
                spaghettiBolognese.GetDescription());

            Console.ReadLine();
        }
    }
}
