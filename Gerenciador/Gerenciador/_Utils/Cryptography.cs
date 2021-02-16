﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador
{
    /// <summary>
    /// Classe de extensão responsável por conter métodos de criptografia de dados.
    /// </summary>
    public static class Cryptography
    {
        private const int KeySize = 10;
        private const int BlockSize = 4;
        private static byte[] _key = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static string Encrypt(this string clearText)
        {
            if (!string.IsNullOrEmpty(clearText))
            {
                string EncryptionKey = "D@SM&ONLINE";
                byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        clearText = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }

            return clearText;
        }
        public static string Decrypt(this string cipherText)
        {
            try
            {
                string EncryptionKey = "D@SM&ONLINE";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;
            }
            catch (Exception)
            {
                return cipherText;
            }
        }


        public static int Encrypt(this int clearText)
        {
            try
            {
                byte[] input = BitConverter.GetBytes(clearText);
                if (IsNeedReverse())
                    input = Reverse(input);
                System.Diagnostics.Debug.Assert(input.Length == BlockSize);
                byte[] result = Skip32(_key, input, 0, true);
                if (IsNeedReverse())
                    result = Reverse(result);
                return BitConverter.ToInt32(result, 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Decrypt(this int cipherText)
        {
            try
            {
                byte[] input = BitConverter.GetBytes(cipherText);
                if (IsNeedReverse())
                    input = Reverse(input);
                System.Diagnostics.Debug.Assert(input.Length == BlockSize);
                byte[] result = Skip32(_key, input, 0, false);
                if (IsNeedReverse())
                    result = Reverse(result);
                return BitConverter.ToInt32(result, 0);
            }
            catch (Exception)
            {
                return cipherText;
            }
        }
        // IsNeedReverse
        //
        // Determines of the bytes of an integer need to be reversed.
        private static bool IsNeedReverse()
        {
            return !BitConverter.IsLittleEndian;
        }
        // Reverse
        //
        // Reverse a byte array
        private static byte[] Reverse(byte[] input)
        {
            byte[] result = new byte[input.Length];
            for (int i = 0; i < input.Length; ++i)
                result[i] = input[input.Length - i - 1];
            return result;
        }
        private static byte[] Skip32(byte[] key, byte[] input, int start, bool isEncrypt)
        {
            // By logic, the following are known to be true
            System.Diagnostics.Debug.Assert(key != null);
            System.Diagnostics.Debug.Assert(key.Length == KeySize);
            System.Diagnostics.Debug.Assert(input != null);
            System.Diagnostics.Debug.Assert(start >= 0);
            System.Diagnostics.Debug.Assert(start <= input.Length - 4);

            int k; /* round number */
            int i; /* round counter */
            int kstep;
            UInt16 wl, wr;

            /* sort out direction */
            if (isEncrypt)
            {
                kstep = 1;
                k = 0;
            }
            else
            {
                kstep = -1;
                k = 23;
            }

            /* pack into words */
            wl = Convert.ToUInt16((input[start + 0] << 8) + input[start + 1]);
            wr = Convert.ToUInt16((input[start + 2] << 8) + input[start + 3]);

            /* 24 feistel rounds, doubled up */
            for (i = 0; i < 12; ++i)
            {
                wr ^= Convert.ToUInt16(G(key, k, wl) ^ k);
                k += kstep;
                wl ^= Convert.ToUInt16(G(key, k, wr) ^ k);
                k += kstep;
            }

            /* implicitly swap halves while unpacking */
            byte[] result = new byte[4];
            result[0] = Convert.ToByte(wr >> 8);
            result[1] = Convert.ToByte(wr & 0xFF);
            result[2] = Convert.ToByte(wl >> 8);
            result[3] = Convert.ToByte(wl & 0xFF);
            return result;
        }

        private static byte[] _ftable = new byte[256] {
            0xa3,0xd7,0x09,0x83,0xf8,0x48,0xf6,0xf4,0xb3,0x21,0x15,0x78,0x99,0xb1,
            0xaf,0xf9,0xe7,0x2d,0x4d,0x8a,0xce,0x4c,0xca,0x2e,0x52,0x95,0xd9,0x1e,
            0x4e,0x38,0x44,0x28,0x0a,0xdf,0x02,0xa0,0x17,0xf1,0x60,0x68,0x12,0xb7,
            0x7a,0xc3,0xe9,0xfa,0x3d,0x53,0x96,0x84,0x6b,0xba,0xf2,0x63,0x9a,0x19,
            0x7c,0xae,0xe5,0xf5,0xf7,0x16,0x6a,0xa2,0x39,0xb6,0x7b,0x0f,0xc1,0x93,
            0x81,0x1b,0xee,0xb4,0x1a,0xea,0xd0,0x91,0x2f,0xb8,0x55,0xb9,0xda,0x85,
            0x3f,0x41,0xbf,0xe0,0x5a,0x58,0x80,0x5f,0x66,0x0b,0xd8,0x90,0x35,0xd5,
            0xc0,0xa7,0x33,0x06,0x65,0x69,0x45,0x00,0x94,0x56,0x6d,0x98,0x9b,0x76,
            0x97,0xfc,0xb2,0xc2,0xb0,0xfe,0xdb,0x20,0xe1,0xeb,0xd6,0xe4,0xdd,0x47,
            0x4a,0x1d,0x42,0xed,0x9e,0x6e,0x49,0x3c,0xcd,0x43,0x27,0xd2,0x07,0xd4,
            0xde,0xc7,0x67,0x18,0x89,0xcb,0x30,0x1f,0x8d,0xc6,0x8f,0xaa,0xc8,0x74,
            0xdc,0xc9,0x5d,0x5c,0x31,0xa4,0x70,0x88,0x61,0x2c,0x9f,0x0d,0x2b,0x87,
            0x50,0x82,0x54,0x64,0x26,0x7d,0x03,0x40,0x34,0x4b,0x1c,0x73,0xd1,0xc4,
            0xfd,0x3b,0xcc,0xfb,0x7f,0xab,0xe6,0x3e,0x5b,0xa5,0xad,0x04,0x23,0x9c,
            0x14,0x51,0x22,0xf0,0x29,0x79,0x71,0x7e,0xff,0x8c,0x0e,0xe2,0x0c,0xef,
            0xbc,0x72,0x75,0x6f,0x37,0xa1,0xec,0xd3,0x8e,0x62,0x8b,0x86,0x10,0xe8,
            0x08,0x77,0x11,0xbe,0x92,0x4f,0x24,0xc5,0x32,0x36,0x9d,0xcf,0xf3,0xa6,
            0xbb,0xac,0x5e,0x6c,0xa9,0x13,0x57,0x25,0xb5,0xe3,0xbd,0xa8,0x3a,0x01,
            0x05,0x59,0x2a,0x46
        };

        private static UInt16 G(byte[] key, int k, UInt16 w)
        {
            byte g1, g2, g3, g4, g5, g6;

            g1 = Convert.ToByte((w >> 8) & 0xff);
            g2 = Convert.ToByte(w & 0xff);

            g3 = Convert.ToByte(_ftable[g2 ^ key[(4 * k) % 10]] ^ g1);
            g4 = Convert.ToByte(_ftable[g3 ^ key[(4 * k + 1) % 10]] ^ g2);
            g5 = Convert.ToByte(_ftable[g4 ^ key[(4 * k + 2) % 10]] ^ g3);
            g6 = Convert.ToByte(_ftable[g5 ^ key[(4 * k + 3) % 10]] ^ g4);

            return Convert.ToUInt16((g5 << 8) + g6);
        }
    }
}