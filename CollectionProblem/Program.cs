namespace CollectionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Collection Practice Problem  *****");
            Console.Write("1. Remaining Chapter in a book.\n2. Maximum Selling Price for two basket.\nEnter your choice:  ");
            int choice =  Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RemainChapter remainChapter = new RemainChapter();
                    remainChapter.ChapterCount();
                    break;
                case 2:
                    SellingPrice price = new SellingPrice();
                    price.MaxPrice();
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }            
        }
    }
}