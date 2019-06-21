using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Settings/World")]
public class WordSettings : SingletonSettings<WordSettings>
{

    public int hpMax;
    public int hpCurrent;

    public int[] stats = new int[4];
    public int[] statsMod = new int[4];
    public int[] carac = new int[20];
    public int[] caracBase = new int[20];
    public int[] caracLvlPoint = new int[20];
    public int[] caracMod = new int[20];
    public int[] caracPointPerLvl = new int[16];

    public string nom;
    public string prenom;
    public string surnom;
    public string classe;
    public string race;
    public int dVie;
    public int bonusDVie;

    public int lvl;
    public int statsPoint;
    public int caracPoint;

    public int armeAtck;
    public int armePrd;
    public int armorDefPhy;
    public int armorDefMag;
    public int armorEsq;

 


    public bool PlayerExist()
    {
        return nom != null;
    }

    

    public void ResetPlayer()
    {
        hpMax = 0;
        hpCurrent = 0;
        for (int i = 0; i < 4; i++)
        {
            stats[i] = 10;
            statsMod[i] = -4;
        }

        for (int i = 0; i < 20; i++)
        {
            carac[i] = 10;
            caracMod[i] = 0;
            caracLvlPoint[i] = 0;
        }

        

        for (int i = 1; i< 10; i++)
        {
            caracBase[i] = 10;
        }
       
        for(int i = 11; i <18; i++)
        {
            caracBase[i] = 10;
        }

        caracBase[0] = 6 + (int)Mathf.Round(Mathf.Max(Random.Range(1, 5), Random.Range(1, 5), Random.Range(1, 5)));
        dVie = 2;
        bonusDVie = 0;
        caracBase[10] = caracBase[18] = caracBase[19] = 0;

        nom = prenom = surnom = null;



        lvl = 1;
        statsPoint = 0;
        caracPoint = 0;
        armeAtck = 0;
        armePrd = 0;
        armorDefPhy = 0;
        armorDefMag = 0;
        armorEsq = 0;
    }



    public int SomStat()
    {
        int rep = 0;
        foreach (int i in stats)
        {
            rep += i;
        }
        return rep;
    }

    public void UpdateCarac()
    {

        carac[0] = caracBase[0] + caracLvlPoint[0] + bonusDVie + statsMod[3];
        carac[1] = caracBase[1] + caracLvlPoint[1] + statsMod[0];
        carac[2] = caracBase[2] + caracLvlPoint[2] + statsMod[1];
        carac[3] = caracBase[3] + caracLvlPoint[3] + statsMod[1];
        carac[4] = caracBase[4] + caracLvlPoint[4] + statsMod[2];
        carac[5] = caracBase[5] + caracLvlPoint[5] + statsMod[3] + armorDefPhy;
        carac[6] = caracBase[6] + caracLvlPoint[6] + statsMod[2] + armorDefMag;
        carac[7] = caracBase[7] + caracLvlPoint[7] + Mathf.Max(statsMod[1], statsMod[3] + armePrd);
        carac[8] = caracBase[8] + caracLvlPoint[8] + statsMod[1] + armorEsq;
        carac[9] = caracBase[9] + caracLvlPoint[9] + statsMod[2];
        carac[10] = caracBase[10]  + caracLvlPoint[10] + (int)Mathf.Floor(stats[1] / 10);
        carac[11] = caracBase[11] + caracLvlPoint[11] ;
        carac[12] = caracBase[12] + caracLvlPoint[12] + statsMod[1] + statsMod[2];
        carac[13] = caracBase[13] + caracLvlPoint[13] + statsMod[3];
        carac[14] = caracBase[14] + caracLvlPoint[14] + statsMod[3];
        carac[15] = caracBase[15] + caracLvlPoint[15] + statsMod[3];
        carac[16] = caracBase[16] + caracLvlPoint[16] + statsMod[3];
        carac[17] = caracBase[17] + caracLvlPoint[17] + statsMod[3];
        carac[18] = caracBase[18] + caracLvlPoint[18] +(int)Mathf.Floor(stats[3] / 10);
        carac[19] = caracBase[19] + caracLvlPoint[19] ;
        
    }


    public void SetdVie(int i)
    {
        dVie = 2 + i;
    }

    public void SetBonusVie()
    {
        bonusDVie = 0;
        for(int i = 0; i <lvl; i++)
        {
            bonusDVie += (int)Mathf.Round(Random.Range(1, dVie ));
        }
    }


    public void SetCaracPoint(int n)
    {
        for(int i = 0; i<=n; i++ )
        {
            caracPoint += caracPointPerLvl[i];
        }
    }


    public void LvlUp()
    {
        lvl++;
        caracPoint += caracPointPerLvl[lvl];
        bonusDVie += (int)Mathf.Round(Random.Range(1, dVie));

    }
}


