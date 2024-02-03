using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Treasure : Collectable
    {
        protected int Score;

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalScore();
        }

        protected void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
    }
}
