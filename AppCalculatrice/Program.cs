// See https://aka.ms/new-console-template for more information
using AppCalculatrice;


OperationClass opclass = new OperationClass();

//"menuop" sert a demander a l'utilisateur si il veut une operation entre 2 entiers ou 2 reels
// en C# en est obliger de faire une conversion lorau'on utilisateur entre un nombre au clavier
// Car tout ce qui est saisie au clavier est considerer comme chaine de caractere
int menuop(string nomOp)
{
    int choose=0;
    string rep;
    bool reussi = false;
    do
    {
        Console.WriteLine("Taper 1 pour faire une {0} entiere, 2 pour une {0} decimale",nomOp);
        rep = Console.ReadLine();
        reussi = int.TryParse(rep, out int result);
        if (reussi)
        {
            //Console.WriteLine("ok");
            choose = int.Parse(rep);
        }
    }while (choose == 1 && choose ==2); //le Et se transorfme en OU et inversement
    //Console.WriteLine("ok");

    return choose;
    
}

/* "sasieInt" est une fonction qui renvoie un tuple de deux entiers, elle a pour but de demander le saisie des deux nombres
 a calculer tou en verifiant qu'il s'agit bien d'entiers
 */
(int,int) saisieInt()
{
    int a, b;
    bool verif1, verif2;
    string s1, s2;
    string resaisir = "Entree invalide, Veuillez saisir un nombre ENTIER";
    do
    {
        Console.WriteLine("Entrer le premier nombre entier");
        s1 = Console.ReadLine();
        /* int.TryParse(a, out int result) verifie si l'entree est un nombre entier(en int) il renvoie true ou false.
        TryParse est une methode qui appartient a la classe int ( il y aussi pour double, float...)
        si la conversion reussit, la valeur est stockee dans la variable "result" et la methode renvoie True
        sinon elle renvoie false*/
        verif1 = int.TryParse(s1, out int result1);
        if (!verif1)
        {
            Console.WriteLine(resaisir);
        }

    } while (!verif1);
    a = int.Parse(s1);

    do
    {
        Console.WriteLine("Entrer le deuxieme nombre entier");
        s2 = Console.ReadLine();
        
        verif2 = int.TryParse(s2, out int result2);
        if (!verif2)
        {
            Console.WriteLine(resaisir);
        }

    } while (!verif2);
    b = int.Parse(s2);

    return (a, b);

}

/* "sasieDouble" est une fonction qui renvoie un tuple de deux reels, elle a pour but de demander le saisie des deux nombres
 a calculer tou en verifiant qu'il s'agit bien d'entiers
 */
(double,double) saisieDouble()
{
    double a, b;
    bool verif1, verif2;
    string s1, s2;
    string resaisir = "Entree invalide, Veuillez saisir un nombre REEL";
    do
    {
        Console.WriteLine("Entrer le premier nombre reel");
        s1 = Console.ReadLine();
        verif1 = double.TryParse(s1, out double result1);
        if (!verif1)
        {
            Console.WriteLine(resaisir);
        }

    } while (!verif1);
    a = double.Parse(s1);

    do
    {
        Console.WriteLine("Entrer le deuxieme nombre reel");
        s2 = Console.ReadLine();
        verif2 = double.TryParse(s2, out double result2);
        if (!verif2)
        {
            Console.WriteLine(resaisir);
        }

    } while (!verif2);
    b = double.Parse(s2);

    return (a, b);

}

int menu()
{
    string choix;
    int ch;
    do
    {
        Console.WriteLine("Ce programme permet d'effectuer des operations");
        Console.WriteLine("1-Adition");
        Console.WriteLine("2-Soustraction");
        Console.WriteLine("3-Divison");
        Console.WriteLine("4-Multiplication");
        Console.WriteLine("5-quitter");
        Console.WriteLine("Faites votre choix");
        choix = Console.ReadLine();
        ch = int.Parse(choix);

    } while (ch<1 &&ch >5);
    return ch;
}

do
{
    int entDeci, nb1Int, nb2Int;
    double nb1Db, nb2Db;
    int choix = menu();
    switch (choix)
    {
        case 1:
            entDeci = menuop("addition");
            if (entDeci == 1)
            {
                (nb1Int, nb2Int) = saisieInt();
                Console.WriteLine("la somme de {0} et {1} est : {2}", nb1Int, nb2Int, opclass.AdditionInt(nb1Int, nb2Int));
            }
            else
            {
                (nb1Db, nb2Db) = saisieDouble();
                Console.WriteLine("la somme de {0} et {1} est : {2}", nb1Db, nb2Db, opclass.AdditionDouble(nb1Db, nb2Db));
            }

            break;

        case 2:
            entDeci = menuop("soustraction");
            if (entDeci == 1)
            {
                (nb1Int, nb2Int) = saisieInt();
                Console.WriteLine("la difference entre {0} et {1} est : {2}", nb1Int, nb2Int, opclass.SoustractionInt(nb1Int, nb2Int));
            }
            else
            {
                (nb1Db, nb2Db) = saisieDouble();
                Console.WriteLine("la somme de {0} et {1} est : {2}", nb1Db, nb2Db, opclass.SoustractionDouble(nb1Db, nb2Db));
            }
            break;

        case 3:
            entDeci = menuop("multiplication");
            if (entDeci == 1)
            {
                (nb1Int, nb2Int) = saisieInt();
                Console.WriteLine("le produit de {0} et {1} est : {2}", nb1Int, nb2Int, opclass.MultiplicationInt(nb1Int, nb2Int));
            }
            else
            {
                (nb1Db, nb2Db) = saisieDouble();
                Console.WriteLine("le produit de {0} et {1} est : {2}", nb1Db, nb2Db, opclass.MultiplicationDouble(nb1Db, nb2Db));
            }
            break;

        case 4:
            entDeci = menuop("division");
            if (entDeci == 1)
            {
                (nb1Int, nb2Int) = saisieInt();
                Console.WriteLine("la quotient de {0} par {1} est : {2}", nb1Int, nb2Int, opclass.DivisionInt(nb1Int, nb2Int));
            }
            else
            {
                (nb1Db, nb2Db) = saisieDouble();
                Console.WriteLine("la quotient de {0} par {1} est : {2}", nb1Db, nb2Db, opclass.DivisionDouble(nb1Db, nb2Db));
            }
            break;

    } 
    if (choix == 5)
    {
        Console.WriteLine("Merci d'avoir utiliser le programme, a bientot");
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
