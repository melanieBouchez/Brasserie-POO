using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Brasserie.Model.Restaurant.People;

namespace Brasserie.Model.Restaurant.People
{
    public class CustomersCollection : ObservableCollection<Customer>
    {
        public CustomersCollection() { }
        public new void AddCustomer(Customer customer)
        {
            //Si le count est à 0, il ne va pas tester la suite et pas se planter. Il ne va pas, du coup, tester le reste
            if (this.Count == 0 || !this.Any(CustomersCollection => CustomersCollection.Id == customer.Id || CustomersCollection.FirstName == customer.FirstName && CustomersCollection.LastName == customer.LastName))
            {
                this.Add(customer);
            }
            else
            {
                //id item or item name already in the collection and will not be added.
            }
        }
        public void SendPromotionalEmail()
        {
            // pour + tard, envoi d'un mail
        }

        public double NewCustomersPercentage => ComputeTypePercentage(Customer.CustomerType.New);


        public double OccasionalCustomersPercentage => ComputeTypePercentage(Customer.CustomerType.Occasional);
        

        // Propriété: Pourcentage de clients réguliers
        public double RegularCustomersPercentage => ComputeTypePercentage(Customer.CustomerType.Regular);


        public double ComputeTypePercentage(Customer.CustomerType type)
        {
            
            int countType = Items.Count(c => c.Type == type);
            return Count != 0 ? 100.0 * ((double)countType / Count) : 0.0;
        }

        

    }
}
