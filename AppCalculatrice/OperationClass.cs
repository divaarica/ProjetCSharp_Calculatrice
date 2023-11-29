using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculatrice
{
    public class OperationClass
    {
        /// <summary>
        /// Cette methode permet de faire une addition de deux entiers
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">entier2</param>
        /// <returns></returns>
        public int AdditionInt(int a, int b)
        {
            //retourne de la somme de a et b
            return a + b;
        }

        /// <summary>
        /// Cette methode permet de faire une addition de deux reels
        /// </summary>
        /// <param name="a">reel1</param>
        /// <param name="b">reel2</param>
        /// <returns></returns>
        public double AdditionDouble(double a, double b)
        {
            //retourne de la somme de a et b
            return a + b;
        }

        /// <summary>
        /// Cette methode permet de faire la soustraction de deux entiers
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">entier2</param>
        /// <returns></returns>
        public int SoustractionInt(int a, int b)
        {
            //retourne de la difference de a et b
            return a - b;
        }

        /// <summary>
        /// Cette methode permet de faire une soustraction de deux reels
        /// </summary>
        /// <param name="a">reel1</param>
        /// <param name="b">reel2</param>
        /// <returns></returns>
        public double SoustractionDouble(double a, double b)
        {
            //retourne de la difference de a et b
            return a - b;
        }

        /// <summary>
        /// Cette methode permet de faire une multiplication de 2 entiers
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">entier2</param>
        /// <returns></returns>
        public int MultiplicationInt(int a, int b)
        {
            //retourne de la multiplication de a et b
            return a * b;
        }

        /// <summary>
        /// Cette methode permet de faire une multiplication de 2 reels
        /// </summary>
        /// <param name="a">reel1</param>
        /// <param name="b">reel2</param>
        /// <returns></returns>
        public double MultiplicationDouble(double a, double b)
        {
            //retourne de la multiplication de a et b
            return a * b;
        }

        /// <summary>
        /// Cette methode permet de faire une division entre 2 entiers
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">entier2</param>
        /// <returns></returns>
        public int DivisionInt(int a, int b)
        {
            //retourne de la multiplication de a et b
            return a / b;
        }

        /// <summary>
        /// Cette methode permet de faire une division entre 2 reels
        /// </summary>
        /// <param name="a">ree1</param>
        /// <param name="b">reel2</param>
        /// <returns></returns>
        public double DivisionDouble(double a, double b)
        {
            //retourne de la multiplication de a et b
            return a / b;
        }

    }
}
