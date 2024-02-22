//using Android.Widget;
//using Java.Lang;
//using Android.Net;
using Microsoft.Maui.Devices.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.People
{

    public class Person
    {
        private int _id;
        private string _lastName;
        private string _firstName;
        private bool _gender;
        private string _email;
        private string _mobilePhoneNumber;

        private static int _totalPersons;


        /*public Person(int id, string lastName = "nom", string firstName = "prenom", bool gender = true, string email = "", string mobilePhoneNumber = "")
        {
            _id = id;
            _lastName = lastName;
            _firstName = firstName;
            _gender = gender;
            _email = email;
            _mobilePhoneNumber = mobilePhoneNumber;
            
        }*/

        public Person() { }

        public int Id { get => _id; set => _id = value; }

        public string LastName
        {
            get => _lastName;

            set
            {
                if (CheckEntryName(value))
                {
                    _lastName = value;
                }
            }
        }

        public string FirstName
        {
            get => _firstName;

            set
            {
                if (CheckEntryName(value))
                {
                    _firstName = value;
                }
            }
        }

        public bool Gender
        {
            get => _gender;

            set => _gender = value;
        }

        public string Email
        {
            get => _email;

            set
            {
                if (CheckEmail(value))
                {
                    _email = value;
                }
            }
        }
        /// <summary>
        /// Totalisateur d'instance de  classe Persons
        /// </summary>
        public static int TotalPersons
        { 
            get => _totalPersons; 
            private set => _totalPersons = value; 
        }


        public string MobilePhoneNumber
        {
            get => _mobilePhoneNumber;

            set
            {
                if (CheckMobilePhoneNumber(value))
                {
                    _mobilePhoneNumber = value;
                }
            }
        }

        /// <summary>
        /// Check LastName or FirstName 
        /// MAJ start each part, no double space or -, no special character, no accented character like éèê
        /// ex: Pierre-Jean-Henri De La Fontaine -> accepted
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public bool CheckEntryName (string name)
        {
            //name = "P- Henri";
            //si le nom débute ou termine par un espace ou un tiret
            if (name.StartsWith(" ") || name.StartsWith("-") || name.EndsWith(" ") || name.EndsWith("-"))
                {
                //MessageBox.Show($"La saisie {name} ne peut commencer ou se terminer par un espace ou un tiret", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
                }
            //si le nom contient au moins un double espace.
            if (name.Contains("  ") || name.Contains("--"))
            {
                //MessageBox.Show($"La saisie {name} comporte au moins un double espace ou 
                //tiret non autorisé", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            //test s'il y a présence de caractère spéciaux (en dehors de l'alphabet) ou 
            //accentués sans tenir compte d'un espace ou un tiret (derrière le Z: Z -)
            if (!Regex.IsMatch(name,@"^[a-zA-Z -]*]"))
            {
                //MessageBox.Show($"La saisie {name} ne peut comporter de caractères spéciaux 
                //ou accentués", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);

                return false;
            }

            string[] nameParts = name.Split('-', ' ');
            foreach (string s in nameParts)
            {
                //test si la première lettre est une majuscule et les suivantes de a à z en 
                //minuscule et sans accent
            if (!Regex.IsMatch(s, @"^[A-Z][a-z]*$"))
                {
                    //MessageBox.Show($"La saisie {name} ne correpond pas aux critères. La 
                    //première lettre de chaque élément qui compose la saisie doit être une majuscule et les
                    //suivantes des minuscules.", $"Erreur de saisie { name}
                    //", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
            }
            //tous les test concluants, saisie valide
            return true;
        }

        /// <summary>
        /// check a personal email adress with no specific format
        /// </summary>
        /// <param name="tryEmail"></param>
        /// <returns></returns>
        public static bool CheckEmail(string tryEmail)
        {
            /*format accepté semblable à "a@b.com";
             obligatoirement de 1 à 25 caractères de a z, 0 à 9 puis obligatoirement le @ puis 
             obligatoirement de 1 à 20 caractère de a z, 0 à 9 puis un . puis 2 à 3 caractères 
             (be, com, fr, ...*/

            if (!string.IsNullOrEmpty(tryEmail)) 
            {
                if (!Regex.IsMatch(tryEmail, @"^[a-z0-9]{1,25}@[a-z0-9]{1,20}\.[a-z]{2,3}$"))
                {
                    //MessageBox.Show($"L'adresse mail est incorrecte", "Erreur de saisie", 
                    //MessageBoxButton.OK, MessageBoxImage.Warning);

                    return false;
                }
                return true;
            }
            return false;

        }

        /// <summary>
        /// Check belgian mobile phone number 
        /// ou 0475 321990 ou +32475321990
        /// </summary>
        /// <param name="tryPhone"></param>
        /// <returns></returns>
        private bool CheckMobilePhoneNumber(string tryPhone)
        {
            if (!string.IsNullOrEmpty (tryPhone))
            {
                if (!Regex.IsMatch(tryPhone, @"^(?:\+32|0)4\d{8}$"))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        

        public Person (int id, string lastName="nom", string firstName = "prenom", bool gender = true, string email = "", string mobilePhoneNumber = "")
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Email = email;
            MobilePhoneNumber = mobilePhoneNumber;
            TotalPersons++;
        }

       
    }
}
