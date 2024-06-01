using SharpimoteClient.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SharpimoteClient.Credentials
{
    internal abstract class CredGenerator
    {
        public static string GenerateCode()
        {
            const int CODE_LENGTH = 9;
            Random digitRandomizer = new Random();
            int digitBeforeCheck, digitOccurrence = 0;
            string resultedCode = string.Empty;
            int digitAfterCheck;
            for (int i=0; i<CODE_LENGTH; i++)
            {
                digitBeforeCheck = digitRandomizer.Next(0,10);
                foreach(char digitAsChar in resultedCode)
                {
                    if(digitAsChar == digitBeforeCheck)
                        digitOccurrence++;
                }
                if(digitOccurrence > 2)
                {
                    do
                    {
                        digitAfterCheck = digitRandomizer.Next(0, 10);
                    }
                    while (digitAfterCheck == digitBeforeCheck);
                }
                else
                {
                    digitAfterCheck = digitBeforeCheck;
                }
                resultedCode += digitAfterCheck.ToString();
            }
            return resultedCode;
        }
        public static string GeneratePassword()
        {
            const int PASS_LENGTH = 8;
            // Define a regular expression pattern to match the password.
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,8}$";

            // Generate a new random password until it matches the pattern.
            Random rand = new Random();
            string password;
            do
            {
                // Generate a new password of the specified length.
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                password = new string(Enumerable.Repeat(chars, PASS_LENGTH).Select(s => s[rand.Next(s.Length)]).ToArray());
            } while (!Regex.IsMatch(password, pattern));
            return password;
        }
    }
}
