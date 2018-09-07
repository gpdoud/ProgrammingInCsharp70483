using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cert {

    class Encryption {

        static byte[] key = Encoding.Default.GetBytes(new Guid().ToString().Substring(0, 16));
        static byte[] iv = Encoding.Default.GetBytes(new Guid().ToString().Substring(0, 16));
        static string clearText = "This cert test is hard!";
        static byte[] cypherText;
        static string encryptedText = String.Empty;

        public static void Encrypt() {
            using(var r = Rijndael.Create()) {
                r.Key = key;
                r.IV = iv;
                ICryptoTransform encryptor = r.CreateEncryptor(key, iv);
                using(var ms = new MemoryStream()) {
                    using(var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write)) {
                        using(var writer = new StreamWriter(cs)) {
                            writer.Write(clearText);
                        }
                        cypherText = ms.ToArray();
                    }
                }
            }
        }
        public static void Decrypt() {
            using(var r = Rijndael.Create()) {
                /*
                 * When creating the encryptor or decryptor, the key and iv
                 * are required
                 */
                ICryptoTransform decryptor = r.CreateDecryptor(key, iv);
                using(var ms = new MemoryStream(cypherText)) {
                    using(var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read)) {
                        using(var reader = new StreamReader(cs)) {
                            encryptedText = reader.ReadToEnd();
                        }
                    }
                }
            }
        }
        public static void Start() {
            Encrypt();
            Decrypt();
        }
    }
}
