using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSRSA
{
    public class DigSignatureRSA
    {
        public Key key;

        public DigSignatureRSA(Key key)
        {
            this.key = key;
        }

        private BigInteger CalcHashValueByFNV(string plainText)
        {
            const uint FNV_32_PRIME = 0x01000193;
            uint hval = 0x811c9dc5;
            int i = 0;
            while (i < plainText.Length)
            {
                hval *= FNV_32_PRIME;
                hval ^= (uint)plainText[i];
                i++;
            }

            return hval;
        }

        private BigInteger CalculateHashValue(string plainText)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                BigInteger sig = new BigInteger(bytes);
                return sig;
            }
        }

        public BigInteger GetDigitalSignature(string plainText)
        {
            BigInteger hashValue = CalcHashValueByFNV(plainText);
            BigInteger signature = ArithmeticOperations.PowMod(hashValue, key.d, key.n, 1);
            return signature;
        }

        public bool CheckDigitalSignature(string plainText, BigInteger signature)
        {
            BigInteger m = ArithmeticOperations.PowMod(signature, key.e, key.n, 1);
            BigInteger m1 = CalcHashValueByFNV(plainText);
            if (m1 != m)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public struct Key
    {
        public BigInteger n;
        public BigInteger e;
        public BigInteger d;

        public Key(BigInteger e, BigInteger n, BigInteger d)
        {
            this.n = n;
            this.e = e;
            this.d = d;
        }
    }
}
