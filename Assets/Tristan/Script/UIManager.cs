using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    private int lvl;

    public Text lvlText;
    public Text nom;
    public Text prenom;
    public Text surnom;
    public Text statPoint;
    public Text classe;
    public Text race;
    public Text[] stats;
    public Text[] statsMod;
    public Text caracPoint;
    public Text[] carac;

    

    // Start is called before the first frame update
    void Start()
    {
        lvl = 1;      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LvlPlusUn()
    {
        
        lvl++;
        if (lvl > 15)
        {
            lvl = 15;
        }
        lvlText.text = lvl.ToString();
    }

    public void LvlMoinUn()
    {
        
        lvl--;
        if (lvl < 1)
        {
            lvl = 1;
        }
        lvlText.text = lvl.ToString();
    }


    public void StatPlusFive(int i )
    {
        if(WordSettings.Instance.statsPoint>=5)
        {
            WordSettings.Instance.stats[i] += 5;
            if (WordSettings.Instance.stats[i] > 90)
            {
                WordSettings.Instance.stats[i] = 90;
            }
           
            else
            {
                WordSettings.Instance.statsPoint -= 5;
                WordSettings.Instance.statsMod [i] = (int)Mathf.Floor((WordSettings.Instance.stats[i] - 50) / 10f);
                if (WordSettings.Instance.statsMod[i] > 0)
                {
                    statsMod[i].text = "(+" + WordSettings.Instance.statsMod[i] + ")";
                }
                else
                {
                    statsMod[i].text = "(" + WordSettings.Instance.statsMod[i] + ")";

                }
                stats[i].text = WordSettings.Instance.stats[i].ToString();
            }
        }
        statPoint.text = WordSettings.Instance.statsPoint.ToString();
    }

    public void StatMinusFive( int i)
    {
       
            WordSettings.Instance.stats[i] -= 5;
            if (WordSettings.Instance.stats[i] < 10)
            {
                WordSettings.Instance.stats[i] = 10;
            }

            else
            {
                WordSettings.Instance.statsPoint += 5;
                WordSettings.Instance.statsMod[i] = (int)Mathf.Floor((WordSettings.Instance.stats[i] - 50) / 10f);
            if (WordSettings.Instance.statsMod[i] > 0)
            {
                statsMod[i].text = "(+" + WordSettings.Instance.statsMod[i] + ")";
            }
            else
            {
                statsMod[i].text = "(" + WordSettings.Instance.statsMod[i] + ")";

            }
            stats[i].text = WordSettings.Instance.stats[i].ToString();
            }
        statPoint.text = WordSettings.Instance.statsPoint.ToString();

    }


    public void CaracPlusUn(int i)
    {
        if (WordSettings.Instance.caracPoint > 0)
        {
            WordSettings.Instance.caracLvlPoint[i]++;
            if(WordSettings.Instance.caracLvlPoint[i] + WordSettings.Instance.caracBase[i]>20)
            {
                WordSettings.Instance.caracLvlPoint[i]--;
            }
            else
            {
                 WordSettings.Instance.caracPoint--;
                ValidateStats();
            }

        }
        caracPoint.text = WordSettings.Instance.caracPoint.ToString();
    }

    public void CaracMoinUn(int i)
    {
        WordSettings.Instance.caracLvlPoint[i]--;
        {
            if(WordSettings.Instance.caracLvlPoint[i]<0)
            {
                WordSettings.Instance.caracLvlPoint[i] = 0;
            }
            else
            {
                WordSettings.Instance.caracPoint++;
                ValidateStats();
            }
        }
        caracPoint.text = WordSettings.Instance.caracPoint.ToString();
    }

   

    public void ValidateNom()
    {
        WordSettings.Instance.ResetPlayer();
        WordSettings.Instance.prenom = prenom.text;
        WordSettings.Instance.nom = nom.text;
        WordSettings.Instance.surnom = surnom.text;
        WordSettings.Instance.lvl = lvl;
        WordSettings.Instance.SetCaracPoint(lvl);
        WordSettings.Instance.SetBonusVie();
        WordSettings.Instance.statsPoint = 220 + 10 * (int)Mathf.Floor(lvl/6) - WordSettings.Instance.SomStat();
        WordSettings.Instance.classe = classe.text;
        WordSettings.Instance.race = race.text;
        statPoint.text = WordSettings.Instance.statsPoint.ToString();
        caracPoint.text = WordSettings.Instance.caracPoint.ToString();
    }


    public void ValidateStats()
    {
        
        WordSettings.Instance.UpdateCarac();
        UpdateCarac();
    }

    public void UpdateCarac()
    {
        for(int i = 0; i<carac.Length; i++)
        {
            carac[i].text = (WordSettings.Instance.carac[i]+ WordSettings.Instance.caracMod[i]).ToString();
        }
    }

    public void ValidateCarac()
    {
        WordSettings.Instance.hpCurrent =  WordSettings.Instance.hpMax = WordSettings.Instance.carac[0] * 4;

    }

}
