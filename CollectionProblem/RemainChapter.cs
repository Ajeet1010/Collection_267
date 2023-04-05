using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProblem
{
    // UC1- Program to count remain chapter.
    internal class RemainChapter
    {
        public void ChapterCount()
        {
            int currentChapter = 0;
            Console.Write("Enter no of chapters:  ");
            int chapter = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter start page and end page of each chapter one by one separated by space:  ");
            List<Tuple<int, int>> NoofPage = new List<Tuple<int, int>>();
            for (int i = 0; i < chapter; i++)
            {
                int[] pages = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                NoofPage.Add(new Tuple<int, int>(pages[0], pages[1]));
            }
            Console.Write("\nEnter current reading page:  ");
            int currentPage = Convert.ToInt32(Console.ReadLine());
                        
            for (int i = 0; i < chapter; i++)
            {
                if (NoofPage[i].Item1 <= currentPage && currentPage <= NoofPage[i].Item2)
                {
                    currentChapter = i;
                    break;
                }
            }
                        
            // Remaining chapter
            int remainingChapters = chapter - currentChapter;
            Console.WriteLine("\nNo. of remaining chapter are:  " + remainingChapters);
        }
    }
}
