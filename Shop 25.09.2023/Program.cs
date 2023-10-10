namespace Shop_25._09._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal sneakersPrice = 1000.00m;
            const decimal jacketsPrice = 800.00m;
            const decimal pantsPrice = 400.00m;
            const decimal heatsPrice = 200.00m;
            const decimal glovesPrice = 300.00m;
            const decimal shirtsPrice = 500.00m;

            Console.Write("Укажите количество средств: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.Write("1. Кроссовки - {0}\n2. Куртки - {1}\n3. Штаны - {2}\n4. Шапки - {3}\n5. Перчатки - {4}\n6. Рубашки - {5}\n", sneakersPrice, jacketsPrice, pantsPrice, heatsPrice, glovesPrice, shirtsPrice);

            //Кроссовки
            Console.Write("Укажите количество кроссовок: ");
            int sneakersQuantity = int.Parse(Console.ReadLine());
            decimal sneakersTotalPrice = sneakersQuantity * sneakersPrice;
            balance -= sneakersTotalPrice;
            Console.WriteLine($"В корзину добавлено {sneakersQuantity} кроссовок, на сумму {sneakersTotalPrice}\nТекущий баланс: {balance}");

            //Куртки
            Console.Write("Укажите количество курток: ");
            int jacketsQuantity = int.Parse(Console.ReadLine());
            decimal jacketsTotalPrice = jacketsQuantity * jacketsPrice;
            balance -= jacketsTotalPrice;
            Console.WriteLine($"В корзину добавлено {jacketsQuantity} курток, на сумму {jacketsTotalPrice}\nТекущий баланс: {balance}");

            //Штаны
            Console.Write("Укажите количество штанов: ");
            int pantsQuantity = int.Parse(Console.ReadLine());
            decimal pantsTotalPrice = pantsQuantity * pantsPrice;
            balance -= pantsTotalPrice;
            Console.WriteLine($"В корзину добавлено {pantsQuantity} штанов, на сумму {pantsTotalPrice}\nТекущий баланс: {balance}");

            //Шапки
            Console.Write("Укажите количество шапок: ");
            int heatsQuantity = int.Parse(Console.ReadLine());
            decimal heatsTotalPrice = heatsQuantity * heatsPrice;
            balance -= heatsTotalPrice;
            Console.WriteLine($"В корзину добавлено {heatsQuantity} шапок, на сумму {heatsTotalPrice}\nТекущий баланс: {balance}");

            //Перчатки
            Console.Write("Укажите количество перчаток: ");
            int glovesQuantity = int.Parse(Console.ReadLine());
            decimal glovesTotalPrice = glovesQuantity * glovesPrice;
            balance -= glovesTotalPrice;
            Console.WriteLine($"В корзину добавлено {glovesQuantity} перчаток, на сумму {glovesTotalPrice}\nТекущий баланс: {balance}");

            //Рубашки
            Console.Write("Укажите количество рубашек: ");
            int shirtsQuantity = int.Parse(Console.ReadLine());
            decimal shirtsTotalPrice = shirtsQuantity * shirtsPrice;
            balance -= shirtsTotalPrice;
            Console.WriteLine($"В корзину добавлено {glovesQuantity} рубашек, на сумму {glovesTotalPrice}\nТекущий баланс: {balance}");


            decimal totalPrice = sneakersTotalPrice + jacketsTotalPrice + pantsTotalPrice + heatsTotalPrice + glovesTotalPrice + shirtsTotalPrice;
            byte counter = 0;
            Console.WriteLine("\tOOO \"Рога и копыта\"\t\n************************************\n№\tНаименование\tКол-во\tЦена\t\tСумма");
            counter++;
            Console.WriteLine($"{counter}.\tКроссовки\t{sneakersQuantity}\t{sneakersPrice}\t\t{sneakersTotalPrice}");
            counter++;
            Console.WriteLine($"{counter}.\tКуртки\t\t{jacketsQuantity}\t{jacketsPrice}\t\t{jacketsTotalPrice}");
            counter++;
            Console.WriteLine($"{counter}.\tШтаны\t\t{pantsQuantity}\t{pantsPrice}\t\t{pantsTotalPrice}");
            counter++;
            Console.WriteLine($"{counter}.\tШапки\t\t{heatsQuantity}\t{heatsPrice}\t\t{heatsTotalPrice}");
            counter++;
            Console.WriteLine($"{counter}.\tПерчатки\t{glovesQuantity}\t{glovesPrice}\t\t{glovesTotalPrice}");
            counter++;
            Console.WriteLine($"{counter}.\tРубашки\t\t{shirtsQuantity}\t{shirtsPrice}\t\t{shirtsTotalPrice}");
            Console.WriteLine($"\t\t\t\t\tИтого: {totalPrice}");
            Console.WriteLine($"\t\t\t\t\tОстаток: {balance}");

        }
    }
}