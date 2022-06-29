using System;
using System.Collections.Generic;

Josephus.JosephusPermutation(new List<object> { "C", "o", "d", "e", "W", "a", "r", "s" }, 4);

public class Josephus
{
    public static List<object> JosephusPermutation(List<object> items, int k)
    {

        var resultArr = new List<object>();
        var isFirst = true;
        var index = 0;


        

        while (items.Count > 0)
        {
            index = checkIndex(items, k, index, isFirst);
            isFirst = false;
            resultArr.Add(items[index]);
            items.RemoveAt(index);
            index--;

        }

        static int checkIndex(List<object> items, int k, int startIndex, bool isFirst)
        {

            if (isFirst)
            {
                startIndex += (k-1) ;
                isFirst = false;

            }
            else
            {
                startIndex += k;
            }

            while (startIndex >= items.Count)
            {
                startIndex -= items.Count;
            }
            return startIndex;
        }

        resultArr.ForEach(a =>
        {
            Console.WriteLine(a);
        });
        return resultArr;
    }
}

