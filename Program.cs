using System;
public class Exercise11
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int n, i, j, tmp,inval,p=0;


        Console.Write("Donner la taille du tableau : ");
        n = Convert.ToInt32(Console.ReadLine());

        
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (arr1[j] < arr1[i])
                {
                    tmp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = tmp;
                }
            }
        }
        Console.WriteLine("\nTableau trié :");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr1[i]);
        }
        Console.Write("\n\n");

        /* Insertion du nouveau element.*/

        Console.Write("Entrer la valeur à inserer : ");
        inval = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < n; i++)
            Console.Write("{0} ", arr1[i]);
       
        for (i = 0; i < n; i++)
            if (inval < arr1[i])
            {
                p = i;
                break;
            }
        /*deplacer à droite */
        for (i = n; i >= p; i--)
            arr1[i] = arr1[i - 1];
        /* insertion */
        arr1[p] = inval;

        Console.WriteLine("\nTableau trié aprés insertion :");
        for (i = 0; i < n+1; i++)
        {
            Console.Write("{0}  ", arr1[i]);
        }
    }

}
