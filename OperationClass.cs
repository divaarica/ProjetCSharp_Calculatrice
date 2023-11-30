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
        /// Cette methode permet de faire la somme de deux entiers
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">entier2</param>
        /// <returns></returns>
        public int Addition(int a, int b)
        {
            //retourne de la somme de a et b
            return a + b;
        }

        /// <summary>
        /// Cette methode permet de faire la somme de deux reels
        /// </summary>
        /// <param name="a">reel1</param>
        /// <param name="b">reel2</param>
        /// <returns></returns>
        public double Addition(double a, double b)
        {
            //retourne de la somme de a et b
            return a + b;
        }

        /// <summary>
        /// Cette methode permet de faire la somme d'un entier et d'un reel
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">reel1</param>
        /// <returns></returns>
        public double Addition(int a, double b)
        {
            //retourne de la somme de a et b
            return a + b;
        }

        /// <summary>
        /// Cette methode permet de faire la somme d'un reel et d'un entier
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">reel1</param>
        /// <returns></returns>
        public double Addition(double a, int b)
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
        public int Soustraction(int a, int b)
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
        public double Soustraction(double a, double b)
        {
            //retourne de la difference de a et b
            return a - b;
        }

        /// <summary>
        /// Cette methode permet de faire une soustraction d'un entier et d'un reel
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">reel1</param>
        /// <returns></returns>
        public double Soustraction(int a, double b)
        {
            //retourne de la difference de a et b
            return a - b;
        }

        /// <summary>
        /// Cette methode permet de faire une soustraction d'un reel et d'un entier
        /// </summary>
        /// <param name="a">reel1</param>
        /// <param name="b">entier1</param>
        /// <returns></returns>
        public double Soustraction(double a, int b)
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
        public int Multiplication(int a, int b)
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
        public double Multiplication(double a, double b)
        {
            //retourne de la multiplication de a et b
            return a * b;
        }

        /// <summary>
        /// Cette methode permet de faire une multiplication d'un entier et d'un reel 
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">reel1</param>
        /// <returns></returns>
        public double Multiplication(int a, double b)
        {
            //retourne de la multiplication de a et b
            return a * b;
        }

        /// <summary>
        /// Cette methode permet de faire une multiplication d'un reel et d'un entier 
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">reel1</param>
        /// <returns></returns>
        public double Multiplication(double a, int b)
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
        public double Division(int a, int b)
        {
            //retourne de la multiplication de a et b
            double result = (double)a / b;
            return Math.Round(result, 3);
        }

        /// <summary>
        /// Cette methode permet de faire une division entre 2 reels
        /// </summary>
        /// <param name="a">ree1</param>
        /// <param name="b">reel2</param>
        /// <returns></returns>
        public double Division(double a, double b)
        {
            //retourne de la multiplication de a et b
            //double result = a / b;
            return Math.Round(a / b, 3);
        }

        /// <summary>
        /// Cette methode permet de faire une division entiere d'un entier par un reel
        /// </summary>
        /// <param name="a">entier1</param>
        /// <param name="b">reel1</param>
        /// <returns></returns>
        public double Division(int a, double b)
        {
            //retourne de la multiplication de a et b
            return Math.Round(a / b, 3);
        }

        /// <summary>
        /// Cette methode permet de faire une division entiere entre 2 reels
        /// </summary>
        /// <param name="a">ree1</param>
        /// <param name="b">entier</param>
        /// <returns></returns>
        public double Division(double a, int b)
        {
            //retourne de la multiplication de a et b
            return Math.Round(a / b, 3);
        }

    }
}
