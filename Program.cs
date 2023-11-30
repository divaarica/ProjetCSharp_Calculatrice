// See https://aka.ms/new-console-template for more information
using AppCalculatrice;
using System.Security;


OperationClass opclass = new OperationClass();

/* int.TryParse(a, out int result) verifie si l'entree est un nombre entier(en int) il renvoie true ou false.
        TryParse est une methode qui appartient a la classe int ( egaelement pour double, float...)
        si la conversion reussit, la valeur est stockee dans la variable "result" et la methode renvoie True
        sinon elle renvoie false*/


(string,string) saisieNombres(int choix) //tuple qui va renvoyer deux nombres de type string 
{
    string resaisir = "Entree invalide, Veuillez saisir un nombre";
    string a, b;
    bool verif1, verifNul;
    do
    {
        Console.WriteLine("Veuillez saisir le premier nombre");
        a = Console.ReadLine();
        verif1 = double.TryParse(a, out double result); //verification que la saisie soit bien un nombre
        if (!verif1)
        {
            Console.WriteLine(resaisir);
        }
    } while (!verif1);

    do
    {
        verifNul = false;
        Console.WriteLine("Veuillez saisir le deuxieme nombre");
        b = Console.ReadLine();
        verif1 = double.TryParse(b, out double result);
        if(verif1 && choix==4 && result == 0)//verif si l'enttre est un nombre et si c'est une division et si l'entrre est = a 0
        {
            Console.WriteLine("Le diviseur ne peut pas etre 0");
            verifNul = true;
        }
        if (!verif1)
        {
            Console.WriteLine(resaisir);
        }
    } while (!verif1 || verifNul==true);
    return (a, b);
}


int menu()
{
    string choix;
    int ch;
    bool verif;
    do
    {
        Console.WriteLine("Ce programme permet d'effectuer des operations");
        Console.WriteLine("1-Adition");
        Console.WriteLine("2-Soustraction");
        Console.WriteLine("3-Multiplication");
        Console.WriteLine("4-Division");
        Console.WriteLine("5-quitter");
        Console.WriteLine("Faites votre choix");
        do
        {
            choix = Console.ReadLine();
            verif = int.TryParse(choix, out int result);//verif aue l'entree au clavier soit numerique
            if (!verif)
            {
                Console.WriteLine("Entree Invalide");
            }
        } while (!verif);
        ch = int.Parse(choix);
        if(ch<1 || ch > 5)
        {
            Console.WriteLine("Entree Invalide. Veuillez saisir un des numeros de la liste");
        }

    } while (ch<1 || ch >5);
    return ch;
}

do
{
    string nb1, nb2;
    bool verifnb1Int, verifnb2Int, verifnb1Dbl, verifnb2Dbl;
    int choix = menu();
    //le programme s'arrete si le choi de l'utilisateur est 5
    if (choix == 5)
    {
        Console.WriteLine("Merci d'avoir utiliser le programme, a bientot");
        break;
    }

    (nb1, nb2) = saisieNombres(choix); 
    verifnb1Int = int.TryParse(nb1, out int resultInt); // retourne true, si le premier nombre est un entier sinon false
    verifnb2Int = int.TryParse(nb2, out int resultInt2); // retourne true, si le deuxieme nombre est un entier sinon false
    verifnb1Dbl = double.TryParse(nb1, out double resultDbl);// retourne true, si le premier nombre est un double sinon false
    verifnb2Dbl = double.TryParse(nb2, out double resultDbl2);//retourne true, si le deuxieme nombre est un double sinon false

    switch (choix)
    {
        case 1:
            if (verifnb1Int && verifnb2Int)//le premier nombre et le deuxieme nombre sont des entiers
            {
                Console.WriteLine("la somme de {0} et {1} est : {2}", resultInt, resultInt2, opclass.Addition(resultInt, resultInt2));

            }else if (verifnb1Dbl && verifnb2Dbl)//le premier nombre et le dexieme nombre sont des doubles
            {
                Console.WriteLine("la somme de {0} et {1} est : {2}", resultDbl, resultDbl2, opclass.Addition(resultDbl, resultDbl2));
            }
            else if (verifnb1Int && verifnb2Dbl)//le premier nombre est entier, le deuxiemme reel
            {
                Console.WriteLine("la somme de {0} et {1} est : {2}", resultInt, resultDbl2, opclass.Addition(resultInt, resultDbl2));
            }
            else // le premier est double , le deuxieme int
            {
                Console.WriteLine("la somme de {0} et {1} est : {2}", resultDbl, resultInt2, opclass.Addition(resultDbl, resultInt2));
            }

            break;

        case 2:
            if (verifnb1Int && verifnb2Int)
            {
                Console.WriteLine("la difference entre {0} a {1} est : {2}", resultInt, resultInt2, opclass.Soustraction(resultInt, resultInt2));

            }
            else if (verifnb1Dbl && verifnb2Dbl)
            {
                Console.WriteLine("la difference entre {0} par {1} est : {2}", resultDbl, resultDbl2, opclass.Soustraction(resultDbl, resultDbl2));
            }
            else if (verifnb1Int && verifnb2Dbl)
            {
                Console.WriteLine("la difference entre {0} et {1} est : {2}", resultInt, resultDbl2, opclass.Soustraction(resultInt, resultDbl2));
            }
            else
            {
                Console.WriteLine("la difference entre {0} et {1} est : {2}", resultDbl, resultInt2, opclass.Soustraction(resultDbl, resultInt2));
            }
            break;

        case 3:
            if (verifnb1Int && verifnb2Int)
            {
                Console.WriteLine("le produit de {0} et {1} est : {2}", resultInt, resultInt2, opclass.Multiplication(resultInt, resultInt2));

            }
            else if (verifnb1Dbl && verifnb2Dbl)
            {
                Console.WriteLine("le produit de {0} et {1} est : {2}", resultDbl, resultDbl2, opclass.Multiplication(resultDbl, resultDbl2));
            }
            else if (verifnb1Int && verifnb2Dbl)
            {
                Console.WriteLine("le produit de {0} et {1} est : {2}", resultInt, resultDbl2, opclass.Multiplication(resultInt, resultDbl2));
            }
            else
            {
                Console.WriteLine("le produit de {0} et {1} est : {2}", resultDbl, resultInt2, opclass.Multiplication(resultDbl, resultInt2));
            }
            break;

        case 4:
            if (verifnb1Int && verifnb2Int)
            {
                Console.WriteLine("le quotient de {0} par {1} est : {2}", resultInt, resultInt2, opclass.Division(resultInt, resultInt2));

            }
            else if (verifnb1Dbl && verifnb2Dbl)
            {
                Console.WriteLine("le quotient de {0} par {1} est : {2}", resultDbl, resultDbl2, opclass.Division(resultDbl, resultDbl2));
            }
            else if (verifnb1Int && verifnb2Dbl)
            {
                Console.WriteLine("le quotient de {0} par {1} est : {2}", resultInt, resultDbl2, opclass.Division(resultInt, resultDbl2));
            }
            else
            {
                Console.WriteLine("le quotient de {0} par {1} est : {2}", resultDbl, resultInt2, opclass.Division(resultDbl, resultInt2));
            }
            break;

    }
} while(true);




//racourcis clavier pour commentaire " crtl+k,ctrl+c "
//int a, b;
// bool rep=false;
//string getRep, op;
//do
//{
//    Console.WriteLine("Saisir le premier nombre");
//    a = int.Parse(Console.ReadLine());
//    Console.WriteLine("Saisir le deuxieme nombre");
//    b = int.Parse(Console.ReadLine());
//    Console.WriteLine("Choisir le type d'operation");
//    Console.WriteLine("Addion a");
//    Console.WriteLine("Soustraction s");
//    op = Console.ReadLine();
//    if (op.ToUpper() == "A")
//    {
//        Console.WriteLine("La somme de {0} et {1} est {2}", a, b, opclass.Addition(a, b));
//    }
//    Console.WriteLine("Saisir c pour faire un autre calcul, q pour quitter");
//    getRep = Console.ReadLine();
//    rep = getRep.ToUpper()=="C"?true:false;

//} while (rep);
