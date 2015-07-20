using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PWConvertorDLL
{
    /// <summary>
    /// Author : Bohdan Taraba
    /// </summary>
    public class Password
    {
        private int passwordStrenght;
        public int PasswordStrenght
        {
            get { return passwordStrenght; }
            set { passwordStrenght = value; }
        }


        private string mainString;
        public string MainString
        {
            get { return mainString; }
            set { mainString = value; }
        }


        private string secondaryString;
        public string SecondaryString
        {
            get { return secondaryString; }
            set { secondaryString = value; }
        }

        private bool useNumbers = true;
        private bool useCapitalLetters = true;
        private bool useSpecificCharacters = true;



        /// <summary>
        /// password constructor withoud parameters To set additional parameters use setParameters() method. This sets primary parameters mainString and secondaryString as "password" 
        /// and password strenght as 10. Use properties to set designated values 
        /// </summary>
        public Password()
        {
            mainString = "password";
            secondaryString = "password";
            passwordStrenght = 10;
        }

        /// <summary>
        /// password constructor with parameters. To set additional parameters use setSecondaryParameters() method
        /// </summary>
        /// <param name="mainString">first string to create password</param>
        /// <param name="secondaryString">second string to create password</param>
        /// <param name="passwordStrenght">designated password strenght</param>
        public Password(string mainString,string secondaryString,int passwordStrenght)
        {
            this.mainString = mainString;
            this.secondaryString = secondaryString;
            this.passwordStrenght = passwordStrenght;
        }

        /// <summary>
        /// get generated password
        /// </summary>
        /// <returns>created password</returns>
        public string getPassword()
        {
            return null;
        }
        
        /// <summary>
        /// Optional method to set specific parameters for creating password
        /// </summary>
        /// <param name="useNumbers">password with numbers. Default true</param>
        /// <param name="useCapital">password with capital letters. Default true</param>
        /// <param name="useSpecific">password with specific characters. Default true</param>
        public void setSecondaryParameters(bool useNumbers,bool useCapital,bool useSpecific)
        {
            this.useNumbers = useNumbers;
            this.useCapitalLetters = useCapital;
            this.useSpecificCharacters = useSpecific;
        }

        public decimal getHash(string word) /// private
        {
            decimal value = 0;
            int fakeCharIndex = 5;
            int wordLenght;

            wordLenght = word.Length;
            if (word.Length < 5)
                wordLenght = 5;
            else if (word.Length > 25)
                wordLenght = 25;
            foreach(char c in word)
            {
                fakeCharIndex++;
                if (fakeCharIndex > 32)
                {
                    fakeCharIndex = 32;
                }
                decimal n = c;
                value += (n * fakeCharIndex) + wordLenght;
            }

            return value;
        }
    }
}
