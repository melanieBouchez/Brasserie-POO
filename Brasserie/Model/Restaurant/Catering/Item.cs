﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Brasserie.Model.Restaurant.Catering
{
    #region Attributs
    public class Item
    {
        const int MINCHAR_NAME = 2;
        const int MINCHAR_DESCRIPTION = 10;
        private static string[] ACCEPTED_PIC_EXT_FILES = { ".png", ".jpg" };

        private string _name;
        private string _description;
        private int _id;
        private double _unitPrice;
        private double _vatRate;
        private string _pictureName;

        #endregion

        #region Constructeurs

        public Item(int id, string name, string description,  double unitPrice, double vatRate, string pictureName)
        {
            Name = name;
            Description = description;
            Id = id;
            UnitPrice = unitPrice;
            VatRate = vatRate;
            PictureName = pictureName;
        }
        #endregion

        #region Propriétés

        public string Name 
        { 
            get => _name;

            set
            {
                if (CheckMinLength(value, MINCHAR_NAME))
                {
                    _name = value;
                }
            }
        }

        public string Description
        {
            get => _description;

            set
            {
                if (CheckMinLength(value, MINCHAR_DESCRIPTION))
                {
                    _description = value;
                }
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                if (CheckNotNegative(value))
                {
                    _unitPrice = value;
                }
            }
        }

        public double UnitPrice
        {
            get => _unitPrice;
            set
            {
                if (CheckNotNegative(value))
                {
                    _unitPrice = value;
                }
            }
        }

        /// <summary>
        /// Taux de tva en double (ex : 21% de TVA)
        /// Vérification si taux tva n'est pas négatif
        /// </summary>
        public double VatRate
        {
            get => _vatRate;
            set
            {
                if (CheckNotNegative(value))
                {
                    _vatRate = value;
                }
            }
        }

        private string PictureName
        {
            get => _pictureName;
            set
            {
                if (CheckPicture(value))
                {
                    _pictureName = value;
                }
            }
        }
        #endregion

        #region Méthodes Vérifications

        private bool CheckMinLength (string s, int min)
        {
            return !string.IsNullOrEmpty(s) && s.Length >= min;
        }
        
        /// <summary>
        /// Vérification du nombre positif
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        private bool CheckNotNegative(double d)
        {
            return d > 0.0;
        }

        /// <summary>
        /// Check Picture only admitted .png and .jpg files, minimum and maximum memory size, full file path must exist
        /// </summary>
        /// <param name="path"></param>
        /// <returns>true if file ok</returns>
        static public bool CheckPicture(string path)
        {
            string pattern = "";
            long fileLength;

            foreach (string ext in ACCEPTED_PIC_EXT_FILES)
            {
                pattern += ext + "|";
            }
            pattern = pattern.Substring(0, pattern.Length - 1) + "$";//remove last "|" unuseful

            //test File extension 
            if (!Regex.IsMatch(path, pattern)) //pattern = ".png|.jpg$" -> test if end of string like .png or .jpg
            {
                //MessageBox.Show($"L'extension du fichier photo {path} n'est pas valide", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }



            return true;
        }
        #endregion

    }
}
