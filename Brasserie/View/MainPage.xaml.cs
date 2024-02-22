using Brasserie.Model.Restaurant.Design;
using Brasserie.Model.Restaurant.People;
using static Brasserie.Model.Restaurant.People.Customer;
using Brasserie.Model.Restaurant.Catering;
using System.Collections.ObjectModel;

namespace Brasserie.View
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            EntryCount.Text = count.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void buttonTestCreateFirstPersons_Clicked(object sender, EventArgs e)
        {
            Person firstPerson = new Person(id: 1, lastName: "Beumier", firstName: "Damien", gender: true, email: "dambeumier@gmail.com", mobilePhoneNumber: "0489142293");
            Person secondPerson = new Person(id: 2, lastName: "Deroisin", firstName: "Sophie", gender: false, email: "sophiederoisin@gmail.com", mobilePhoneNumber: "0473121314");
            Person ThirdPerson = new Person(3, "Jandrin", "Marc", true, "jandrinmarc@gmail.com", mobilePhoneNumber: "0485556678");
            Person FourthPerson = new Person(4, "Lupant", "Sebastien");
            Person FifthPerson = new Person();
            //Person TestPerson = new Person( lastName: "Lupant", firstName: "Sebastien");

            Person p;

            //p = new Person(6, "Tardif","Jean");

            //secondPerson._email = "soderoisin@ecole.be";
 
        }
        private void buttonTestEncapsulation_Clicked(object sender, EventArgs e)
        {
            Person p = new Person(id: 2, lastName: "Deroisin", firstName: "Sophie", gender: false, email: "sophiederoisin@gmail.com", mobilePhoneNumber: "0473121314");

            p.FirstName = "Marie-Sophie";
            lblDebug.Text = p.FirstName;

        }

        private void buttonTestStatic_Clicked(object sender, EventArgs e)
        {
            string mail = " mon mail@gmail.com";
            bool testMail = Person.CheckEmail(mail);
            //lblDebug2.Text = $"résultat du test de validité du mail {mail} : {testMail.ToString()}";
            //Person.TotalPersons = 10;
            lblDebug2.Text = $"Nombre d'instances de classe Person : {Person.TotalPersons}";
        }

        private void buttonTestTable_Clicked(object sender, EventArgs e)
        {
            Table t1 = new Table(4, 1, false);
            Table t2 = new Table(6,2, false);

            lblDebug.Text = $"Nombre total de sièges : {Table.TotalSeats}";

        }

        private void buttonTestInherance_Clicked(object sender, EventArgs e)
        {
            Customer c = new Customer(7, "Maggi", "Francesca", false, "francesca190@gmail.com", "0475689034", CustomerType.New);
            StaffMember staffm = new StaffMember(8, "Dries", "François", true, "francoisdries@gmail.com", "0485113289", "BE83 2378 9876 2390", "4,rue du marais 7030 Ghlin", 3275.0);
            Manager m = new Manager(9, "Duchief", "Marc", true, "duchiefmarc@gmail.com", "0491203040", "BE84 1128 9836 3518", "2, rue du pont 7000 Mons", 5200.5, "Password01");

            

        }

        private void buttonTestItem_Clicked(object sender, EventArgs e)
        {
            Item i = new Item("Fanta", "Boisson gazeuse aux extraits d'orange", 1, 2.5, 6.0, "fanta25.png");
        }

        private void buttonTestDerivateItems_Clicked(object sender, EventArgs e)
        {
            Drink d = new Drink("Coca", "Boisson gazeuse", 2, 2.6, 6.0, "", 25.0);
            Beer b = new Beer("Chimay", "Bière Trappiste", 3, 4.5, 6.0, "", 33.0, 6.0, false, true);
            Alcohol a = new Alcohol("Limoncello", "C'est trop bon", 5,6.0,6.0,"limoncello.jpeg",5.0,45.6);
        }

        private void buttonTestCollection_Clicked(object sender, EventArgs e)
        {
            StaffMember staffm1 = new StaffMember(10, "Vandenberg", "Caroline", true, "carovan@gmail.com", "0476893029", "BE81 7345 1290 1038", "10, rue de l'eglise 7030 Ghlin", 3050.0);
            StaffMember staffm2 = new StaffMember(11, "Dries", "Francois", true,"francoisdries@gmail.com","0485113289", "BE83 2378 9876 2390", "130, rue de binche 7030 Ghlin", 3275.0);
            Manager m = new Manager(12, "Legars", "Flavien", true, "legafla@gmail.com","0482426671", "BE83 4435 1893 1450", "5, rue de la cle 7000 Mons", 5500.0, "Password01");

            ObservableCollection<StaffMember> staffmCol = new ObservableCollection<StaffMember>();
            staffmCol.Add(staffm1);
            staffmCol.Add(staffm2);
            staffmCol.Add(m);
            string s = $"\nnombre d'éléments dans la collection : {staffmCol.Count}";

            foreach (StaffMember sm in staffmCol)
            {
                s += $"\n{sm.FirstName} {sm.LastName} : {sm.GetType().ToString()}";
                
            }
            lblDebug.Text = s;
            staffmCol.IndexOf(staffm1);

        }
    }

}
