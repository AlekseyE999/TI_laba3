using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSRSA
{
    public class KeyGenerator
    {
        private Random random = new Random();

        private BigInteger GeneratePrimeNumber(int numByte)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytesArr = new byte[numByte];
            BigInteger number;
            do
            {
                rng.GetBytes(bytesArr);
                number = new BigInteger(bytesArr);

            } while (!ArithmeticOperations.MillerRabinTest(number, 20));

            return number;
        }

        private BigInteger GenerateNumberForPrimeKey(BigInteger phi, int numByte)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytesArr = new byte[numByte];
            BigInteger e;
            do
            {
                rng.GetBytes(bytesArr);
                e = new BigInteger(bytesArr);
            } while (e >= phi || e <= 0 || ArithmeticOperations.GCD(phi, e, out BigInteger x1, out BigInteger y1) != 1);

            return e;
        }

        private BigInteger GenerateNumberForSecretKey(int numByte, BigInteger e, BigInteger phi)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytesArr = new byte[numByte];
            BigInteger d;
            do
            {
                rng.GetBytes(bytesArr);
                d = new BigInteger(bytesArr);

            } while (d <= 0);
            d = ArithmeticOperations.GCD(e, phi, out BigInteger x, out BigInteger y);
            d = (x % phi + phi) % phi;

            return d;
        }

        public Key GenerateKey(int numByte)
        {
            BigInteger q;
            BigInteger p = GeneratePrimeNumber(numByte);
            do
            {
                q = GeneratePrimeNumber(numByte);
            } while (q == p);
            BigInteger n = p * q;
            BigInteger phi = (p - 1) * (q - 1);
            BigInteger e = GenerateNumberForPrimeKey(phi, numByte);
            BigInteger d = GenerateNumberForSecretKey(numByte, e, phi);
            return new Key(e, n, d);
        }
    }
}
