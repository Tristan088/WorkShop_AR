using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Settings/World")]
public class WordSettings : SingletonSettings<WordSettings>
{
    
    public int hpMax;
    public int hpCurrent;
    public int[] stats = new int[4];
    public int[] statsMod = new int[4];
    public int[] carac = new int[20];
    public int[] caracMod = new int[20];
    public string nom;
    public string prenom;
    public string surnom;
    public int lvl;


    public bool PlayerExist()
    {
        return nom != null;
    }

    public void ResetPlayer()
    {
        hpMax = 0;
        hpCurrent = 0;
        for (int i = 0; i<4; i++)
        {
            stats[i] = 10;
            statsMod[i] = -4;
        }

        for(int i = 0; i<20; i++)
        {
            carac[i] = 10;
            caracMod[i] = 0;
        }


        nom = prenom = surnom = null;

        lvl = 1;
        
    }
}

