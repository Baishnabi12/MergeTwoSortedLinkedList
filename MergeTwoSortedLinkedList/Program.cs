using System;
using System.Collections.Generic;
public class ll {
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddLast(30);
        LinkedList<int> list2 = new LinkedList<int>();
        list2.AddLast(50);
        list2.AddLast(60);
        LinkedList<int> list3 = new LinkedList<int>();
        foreach (int i in list)
        {
            list3.AddLast(i);
            Console.WriteLine(i);
        }
        foreach (int i in list2)
        {
            list.AddLast(i);
            Console.WriteLine(i);
        }
    }
}
