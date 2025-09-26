using System.Globalization;

namespace Bar_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char tempGender;
            int tempBeer;
            int tempSoftDrink;
            int tempBarbecue;
            Bill bill = new Bill();

            Console.Write("Sexo: ");
            tempGender = char.Parse(Console.ReadLine().ToUpper());
            while (tempGender != 'F' && tempGender != 'M')
            {
                Console.Write("Valor invalido! Digite F ou M: ");
                tempGender = char.Parse(Console.ReadLine().ToUpper());
            }
            bill.Gender = tempGender;

            Console.Write("Quantidade de cervejas: ");
            tempBeer = int.Parse(Console.ReadLine());
            while(tempBeer < 0)
            {
                Console.Write("Valor invalido! Digite um valor igual ou maior que zero: ");
                tempBeer = int.Parse(Console.ReadLine());
            }
            bill.Beer = tempBeer;

            Console.Write("Quantidade de refrigerantes: ");
            tempSoftDrink = int.Parse(Console.ReadLine());
            while (tempSoftDrink < 0)
            {
                Console.Write("Valor invalido! Digite um valor igual ou maior que zero: ");
                tempSoftDrink = int.Parse(Console.ReadLine());
            }
            bill.SoftDrink = tempSoftDrink;

            Console.Write("Quantidade de espetinhos: ");
            tempBarbecue = int.Parse(Console.ReadLine());
            while (tempBarbecue < 0)
            {
                Console.Write("Valor invalido! Digite um valor igual ou maior que zero: ");
                tempBarbecue = int.Parse(Console.ReadLine());
            }
            bill.Barbecue = tempBarbecue;

            Console.WriteLine("\nRELATORIO:");
            Console.WriteLine("Consumo = R$" + bill.Feeding().ToString("F2", CultureInfo.InvariantCulture));

            if (bill.Cover() > 0) Console.WriteLine("Couvert = R$" + bill.Cover().ToString("F2", CultureInfo.InvariantCulture));
            else Console.WriteLine("Isento de Couvert");

            Console.WriteLine("Ingresso = R$" + bill.Ticket().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nValor a pagar = R$" + bill.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
