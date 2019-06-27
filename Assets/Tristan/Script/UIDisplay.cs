using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIDisplay : MonoBehaviour
{


    public Text hp;
    public Text nom;
    public Text prenom;
    public Text surnom;
    public Text classe;
    public Text race;
    public Text lvl;
    public Text[] stats;
    public Text[] statsMod;
    public Text[] carac;
    public GameObject _continue;
    // Start is called before the first frame update
    void Start()
    {


        if (string.IsNullOrEmpty(WordSettings.Instance.nom))
        {
            _continue.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void UpdateText()
    {
        nom.text = WordSettings.Instance.nom;
        prenom.text = WordSettings.Instance.prenom;
        surnom.text = WordSettings.Instance.surnom;
        classe.text = WordSettings.Instance.classe;
        race.text = WordSettings.Instance.race;
        lvl.text = WordSettings.Instance.lvl.ToString();
        hp.text = "" + WordSettings.Instance.hpCurrent.ToString() + "/" + WordSettings.Instance.hpMax.ToString();
        for (int i = 0; i<3; i++)
        {
            stats[i].text = WordSettings.Instance.stats[i].ToString();
            statsMod[i].text = "("+WordSettings.Instance.statsMod[i].ToString()+")";

        }
        for (int i = 0; i<18; i++)
        {
            carac[i].text = WordSettings.Instance.carac[i].ToString();
        }
    }
}
