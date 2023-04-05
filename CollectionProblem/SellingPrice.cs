using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblem
{
    // Uc2- Maximum selling price.
    internal class SellingPrice
    {
        public void MaxPrice()
        {
            int PriceInBasket_A = 0, PriceInBasket_B = 0;
            Console.WriteLine("N is no of value while K is no of swap\nSwapping should be less than no of value or N > K");
            Console.Write("\nEnter N and K value separated by space: ");
            var obj = Console.ReadLine().Split();
            int N = Convert.ToInt32(obj[0]);
            int K = Convert.ToInt32(obj[1]);

            Console.Write("\nEnter {0} value for basket A of fruit separated by  space ", N);
            string[] value = Console.ReadLine().Split();
            int[] basket_A = value.Select(int.Parse).ToArray();

            Console.Write("\nOnly {1} swapping is allowed\nEnter {0} value for basket B of fruit separated by  space ", N, K);
            value = Console.ReadLine().Split();
            int[] basket_B = value.Select(int.Parse).ToArray();

            //swap
            for (int i = 0; i < K; i++)
            {
                int temp;
                temp = basket_A[i];
                basket_A[i] = basket_B[i];
                basket_B[i] = temp;
            }

            Console.Write("\nBasket A value after swapping is:  ");
            foreach (int swapvalue in basket_A)
            {
                Console.Write(" " + swapvalue);
            }

            Console.Write("\nBasket B value after swapping is:  ");
            foreach (int swapvalue in basket_B)
            {
                Console.Write(" " + swapvalue);
            }
            foreach (int swapvalue in basket_A)
            {
                PriceInBasket_A += swapvalue;
            }
            foreach (int swapvalue in basket_B)
            {
                PriceInBasket_B += swapvalue;
            }
            Console.WriteLine("\nMax Selling Price of basket A is:  " + PriceInBasket_A);
            Console.WriteLine("\nMax Selling Price of basket B is:  " + PriceInBasket_B);

            if (PriceInBasket_A > PriceInBasket_B)
                Console.WriteLine("Max Selling price is for basket A is:  " + PriceInBasket_A);
            else
                Console.WriteLine("Max Selling price is for basket B is:  " + PriceInBasket_B);

        }
    }
}
