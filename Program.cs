using System;
using System.Collections.Generic;

namespace DictionaryHomeWork

{
    class Program
{
    static void Main(string[] args)
    {
        MyDictionary<int, string> myDictonary = new MyDictionary<int, string>();
        myDictonary.Add(1, "Kubi");
        myDictonary.Add(2, "Ece");
        myDictonary.Add(3, "Elif");
        myDictonary.Add(4, "İso");
        Console.WriteLine("CountKey :" + myDictonary.CountKey);
        Console.WriteLine("CountValue :" + myDictonary.CountValue);
        Console.WriteLine("Count :" + myDictonary.Count);
        
       }
}

class MyDictionary<Tkey, Tvalue>
{
    Tkey[] tkeys;
    Tvalue[] tvalues;

    Tkey[] _tempkeys;
    Tvalue[] _tempvalues;

    public MyDictionary()
    {
        tkeys = new Tkey[0];
        tvalues = new Tvalue[0];
    }

    public void Add(Tkey key, Tvalue value)
    {
        tkeys = new Tkey[tkeys.Length + 1];
        tvalues = new Tvalue[tvalues.Length + 1];

        _tempkeys = tkeys;
        _tempvalues = tvalues;



        for (int i = 0; i < tkeys.Length; i++)
        {
            tvalues[i] = _tempvalues[i];
            tkeys[i] = _tempkeys[i];
        }
        tvalues[tvalues.Length - 1] = value;
        tkeys[tkeys.Length - 1] = key;


    }

    public int Count
    {
        get { return tkeys.Length + tvalues.Length; }
    }
    public int CountKey
    {
        get { return tkeys.Length; }
    }

    public int CountValue
    {
        get { return tvalues.Length; }
    }
}

}