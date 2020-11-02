using System;

namespace DL.Repositories
{
    public abstract class ListCounter
    {
        public virtual void GetNumberOfItems()
        {
            int items = 0;
            Console.WriteLine("This repo has this many items in store: " + items);
        }
    }
}