using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChapeau.ChapeauModel
{
    class Wachtwoord
    {
        private bool isSet = false;
        public bool IsSet { get { return isSet; } }

        private int wachtwoordLengte = 4;
        public Wachtwoord(string nieuwWachtwoord)
        {
            this.wachtwoord = nieuwWachtwoord;
        }
        private string wachtwoord
        {
            get
            {
                return wachtwoord;
            }
            set
            {
                wachtwoord=AuthenticatePassword(value);
            }
        }
        private string AuthenticatePassword(string userWachtwoord)
        {
            string wachtwoord = "";
            if (userWachtwoord.Length != wachtwoordLengte)
            {
                for (int i = 0; i < wachtwoordLengte; i++)
                {
                    wachtwoord += '0';
                }
                return wachtwoord;
            }
            else
            {
                foreach (char letter in userWachtwoord)
                {
                    if (!char.IsDigit(letter))
                    {
                        for (int i = 0; i < wachtwoordLengte; i++)
                        {
                            wachtwoord += '0';
                        }
                        return wachtwoord;
                    }
                }            
            }
            this.isSet = true;
            return userWachtwoord;
        }
    }
}
