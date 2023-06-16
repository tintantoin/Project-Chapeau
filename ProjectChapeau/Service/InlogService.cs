
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;
using DAL;
using Model;
using Xceed.Wpf.Toolkit;

namespace Service
{
    public class InlogService
    {
        PersoneelDAO personeelDAO = new PersoneelDAO();

        public FunctieType LogUserIn(string userName, string password)
        {
            Personeel personeel = personeelDAO.GetPersoneelByID(SplitUserName(userName)[1], int.Parse(SplitUserName(userName)[0]));
            if (personeel != null)
            {
                if (personeel.wachtwoord.Trim() == ComputeSha256Hash(password).Trim())
                {
                    return personeel.functie;
                };
            }
            return FunctieType.GeenFunctie;
        }
        public void SetDBWachtwoord(int id, string wachtwoord)
        {
            personeelDAO.ChangePassword(id, ComputeSha256Hash(wachtwoord));
        }
        private string ComputeSha256Hash(string computeThis)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(computeThis));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte bit in bytes)
            {
                stringBuilder.Append(bit.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
        string[] SplitUserName(string username)
        {
            bool numIsNotSet = true;
            bool charIsNotSet = true;
            string[] splitUserName = new string[2];
            foreach (char item in username)
            {
                if (char.IsDigit(item))
                {
                    numIsNotSet = false;
                    splitUserName[0] += item;
                }
                else
                {
                    charIsNotSet = false;
                    splitUserName[1] += item;
                }
            }
            if (charIsNotSet || numIsNotSet)
            {
                splitUserName[0] += 0;
                splitUserName[1] += 0;
            }
            return splitUserName;
        }
    }
}
