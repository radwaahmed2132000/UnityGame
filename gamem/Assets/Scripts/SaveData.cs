using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData 
{
    public static int Storescore;
    public static int myknz;
    public static int knz;
    public static int StoreHealth;
    public static float x;
    public static float y;
    public static List<string> mylist;
    public static int learn;
    public static List<string> sceneHistory = new List<string>();
    public SaveData()
    {
        StoreHealth = 5;
        Storescore = 0;
        
         mylist = new List<string>();
        mylist.Add("Learn1");
        mylist.Add("Learn2");
        mylist.Add("Learn3");
    }
    public static void setheath()
    {
        StoreHealth = 5;
    }
 
    //static SaveData()
    //{
    //    StoreHealth = 5;

    //}
    // Start is called before the first frame update
   
}
