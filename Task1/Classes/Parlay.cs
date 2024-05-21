using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Parlay
    {
        private string horse;
        private int sum;

        public Parlay(string horse, int sum)
        {
            this.horse = horse;
            this.sum = sum;
        }

        public string GetHorse()
        {
            return this.horse;
        }

        public int GetSum()
        {
            return this.sum;
        }
    }
}
