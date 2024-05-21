using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1.Classes
{
    public class Totalizator
    {
        private List<Client> clients;
        private string[] horses;
        public Client? currentUser;

        public Totalizator()
        {
            this.clients = new List<Client>();
            this.horses = new string[] { "Белый Ветер", "Черная Молния", "Золотая Искра", "Серебряный Ручей", "Красный Закат", "Синяя Волна", "Зеленый Луг" };
        }

        public void AddUser(string name,string login, string password)
        {
                this.clients.Add(new Client(name,login, password));
        }

        public bool FindUser(string login, string password)
        {
            Client? client = this.clients.FirstOrDefault(user => user.Enter(login,password));
            if (client != null) 
            {
                this.currentUser= client;
                return true;
            }
            else
            {
                return false;
            }
        }
        public Dictionary<sbyte,string> GenerateResults()
        {
            List<string> horses = this.horses.ToList();
            Dictionary<sbyte,string> result = new Dictionary<sbyte,string>();
            Random rnd = new Random();
            for(sbyte i = 0; i < horses.Count; i++)
            {
                result.Add(i, horses[rnd.Next(horses.Count)]);
            }
            return result;
        }

        public void ClearAllParlays()
        {
            foreach (var user in this.clients.OfType<Client>())
            {
                user.ClearParlays();
            }
        }

        public Dictionary<Client,double> CalculateMoney(Dictionary<sbyte, string> result)
        {
            int sum = ParlaySum();
            var winners = (from c in clients where c.GetParlays().Any(p => p.GetHorse() == result[0])
                           select c).ToList();
            int horsewinnerSum = 0;
            foreach(var winner in  winners)
            {
                horsewinnerSum += winner.GetParlays().FirstOrDefault(p => p.GetHorse() == result[0]).GetSum();
            }
            Dictionary<Client,double> winnersParts = new Dictionary<Client,double>();
            foreach(Client client in winners)
            {
                winnersParts.Add(client, ((client.GetParlays().FirstOrDefault(p => p.GetHorse() == result[0]).GetSum()/(horsewinnerSum+0.0))*100)*sum);
            }
            return winnersParts;
        }


        private int ParlaySum()
        {
            int sum = 0;
            foreach(Client client in this.clients)
            {
                foreach(Parlay parlay in client.GetParlays())
                {
                    sum += parlay.GetSum();
                }
            }
            return sum;
        }
    }
}
