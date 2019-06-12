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
    public Text[] stats;
    

    // Start is called before the first frame update
    void Start()
    {
        lvl = 1;
    }

    // Update is called once per frame
    void Update()
    {
        statPoint.text = WordSettings.Instance.statsPoint.ToString();
    }

    public void LvlPlusUn()
    {
        
        lvl++;
        if (lvl > 30)
        {
            lvl = 30;
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
                stats[i].text = WordSettings.Instance.stats[i].ToString();
            }
        }        
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
                stats[i].text = WordSettings.Instance.stats[i].ToString();
            }
        
    }

   

    public void ValidateNom()
    {
        WordSettings.Instance.prenom = prenom.text;
        WordSettings.Instance.nom = nom.text;
        WordSettings.Instance.surnom = surnom.text;
        WordSettings.Instance.lvl = lvl;
        WordSettings.Instance.statsPoint = 220 + 10 * (int)Mathf.Floor(lvl/6) - WordSettings.Instance.SomStat();
    }


    public void ValidateStats()
    {
        WordSettings.Instance.carac[1] = 10 + WordSettings.Instance.statsMod[0];
        WordSettings.Instance.carac[2] = 10 + WordSettings.Instance.statsMod[1];
        WordSettings.Instance.carac[3] = 10 + WordSettings.Instance.statsMod[1];
        WordSettings.Instance.carac[4] = 10 + WordSettings.Instance.statsMod[2];
        WordSettings.Instance.carac[5] = 10 + WordSettings.Instance.statsMod[3];
        WordSettings.Instance.carac[6] = 10 + WordSettings.Instance.statsMod[2];
        WordSettings.Instance.carac[8] = 10 + WordSettings.Instance.statsMod[1];
        WordSettings.Instance.carac[9] = 10 + WordSettings.Instance.statsMod[2];
        WordSettings.Instance.carac[10] = (int)Mathf.Floor( WordSettings.Instance.stats[1] / 10);
        WordSettings.Instance.carac[11] = 10;
        WordSettings.Instance.carac[12] = 10 + WordSettings.Instance.statsMod[1] + WordSettings.Instance.statsMod[2];
        WordSettings.Instance.carac[13] = 10 + WordSettings.Instance.statsMod[3];
        WordSettings.Instance.carac[14] = 10 + WordSettings.Instance.statsMod[3];
        WordSettings.Instance.carac[15] = 10 + WordSettings.Instance.statsMod[3];
        WordSettings.Instance.carac[16] = 10 + WordSettings.Instance.statsMod[3];
        WordSettings.Instance.carac[17] = 10 + WordSettings.Instance.statsMod[3];
        WordSettings.Instance.carac[18] = (int)Mathf.Floor(WordSettings.Instance.stats[3] / 10);


    }




}
