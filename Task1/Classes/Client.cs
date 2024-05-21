using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Classes
{
    public class Client : User
    {
        private List<Parlay> parlays;

        public string Name { get; }
        public Client(string name, string loginName, string password) : base(loginName, password)
        {
            Name = name;
            this.parlays = new List<Parlay>();
        }

        public void AddParlay(Parlay parlay)
        {
            this.parlays.Add(parlay);
        }

        public void ClearParlays()
        {
            this.parlays.Clear();
        }

        public List<Parlay> GetParlays()
        {
            return this.parlays;
        }
    }
}
