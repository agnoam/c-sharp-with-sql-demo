using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQL_Demo {
    class EncryptionManger {
        public static string MD5(string input) {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create()) {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++) {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private static byte[] getASCII_value(string inputToEncrypt) {
            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(inputToEncrypt);
            return asciiBytes;
        }

        /* encrShift is the key of this encryption because this encryption take the ASCII value of each letter,
           and plus the value of the key and generate it again into letter */
        public static string easyEncryption(string password, string encrShift) {
            byte[] bytesToEncrypt = getASCII_value(password);
            char[] encryptedPass = new char[bytesToEncrypt.Length];

            int j = 0;
            for (int i = 0; i < bytesToEncrypt.Length; i++) {
                // Encrypting
                byte byteToCheck = bytesToEncrypt[i];
                int bit = Convert.ToInt32(byteToCheck);
                int encryptNumber = (int) Char.GetNumericValue(encrShift[j]);
                bit += encryptNumber;

                // Converting the number to char
                encryptedPass[i] = Convert.ToChar(bit);

                j++;
            }

            return new String(encryptedPass);
        }

        public static bool boolFromString(string data) {
            bool b = data == "1";
            return b;
        }
    }
}
