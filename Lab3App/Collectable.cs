using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        protected string Description;
        internal CollectionBoard Board;

        public Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> collection)
        {
            collection.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            
        }

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }

    }
}
