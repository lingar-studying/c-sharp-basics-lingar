using System;
using System.Collections.Generic;
using System.Text;
/*
 * 
 * מיון הכנסה - sort insertion
מיזוג מערכים ממוינים – Merging
תוכנית מיזוג מערכים
מיזוג שני מערכים ממויינים

2 2

6.6 מערכים " דו ממדיים "
) ראה בביליוגרפיה-] 1 [ יסודות מדעי המחשב בסי-שארפ
אוניברסיטת ת"א , תבניות אלגוריתמיות פרק 12(
סריקות במערך דו-מימדי
מערך דו-מימדי – סיכום
ריבוע קסם- פתרון
תוכנית לבדיקה ריבוע קסם
העברת מערך דו-מימדי לפעולה
החזרת מערך דו-מימדי מפעולה
סריקות במערך "סביב" איבר נתון
עבודת כיתה – מערכים דו-מימדיים
*/

//searching 
/// <summary>
/// https://www.geeksforgeeks.org/searching-algorithms-in-java/
/// </summary>
/// 
//Checking complexity: https://www.bigocalc.com/
namespace c_sharp_basics_lingar.algorithmic
{
    public class Sorting
    {

        public static void Demo()
        {
            Console.WriteLine("Here we'll show some sorting");

            int[] test1 = { 4, 33, 4, 555, 7, -1, -9, 55, 6, 34, -3, -55, 347, 7, 5 };

            int[][] arrs = { test1 };

            Console.WriteLine("we'll work on that:");
            foreach(int[] arr in arrs)
            {
                Console.WriteLine(string.Join( ",", arr));

            }
            Console.WriteLine("let's show inserting sorting");

            foreach (int[] arr in arrs)
            {

                int[] copy = (int[])arr.Clone();
                LingarInsertionSort(copy);
                Console.WriteLine(string.Join(",", arr));

            }
        }


        //O(n^2)
        public static void LingarInsertionSort(int[] arr)
        {
            //השיטה שתוחבים את הערך לפני הערך הראשון שהוא גדול ממנו
            //You need to move all the array one forward
            for(int i =0; i< arr.Length-1; i++)
            {
                int j = i + 1;
                if(arr[i] > arr[j])
                {
                    for(int k = j-1; k>=0; k--)
                    {
                        if(arr[k]> arr[j])
                        {
                            int temp = arr[k];
                            arr[k] = arr[j];
                            arr[j] = temp;
                            j--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static void QuickSortTry1(int[] arr, int pivot)
        {

        }


    }
}
