using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pools
    {
        public List<int> Sorteds { get; set; }
        public List<bool> Avaliables { get; set; }

        public Pools(int RouletteMaxNumber, int ListCount)
        {
            Sorteds = new List<int>();
            Avaliables = new List<bool>();
            Random rand = new Random();
            List<int> nums = new List<int>();
            int count = 0;
            for (int i = 1; i<= RouletteMaxNumber; i++)
            {
                nums.Add(i);
            }
            do
            {
                int sort = rand.Next(1, RouletteMaxNumber);
                if (!Sorteds.Contains(sort))
                {
                    Avaliables.Add(true);
                    Sorteds.Add(sort);
                    count++;
                }
            } while (count != ListCount);
            Sorteds.Sort();
        }

        public Pools SortedNumber(int SortedNumber, Pools CurrentPool)
        {
            Pools _pool = CurrentPool;
            for (int i = 0; i < _pool.Sorteds.Count; i++)
            {
                if (_pool.Sorteds[i] == SortedNumber)
                {
                    _pool.Avaliables[i] = false;
                }
            }
            return _pool;
        }
    }
}
