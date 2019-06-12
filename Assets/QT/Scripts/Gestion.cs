using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gestion : MonoBehaviour
{
    public Text nbDice;
    public int _nbDice = 0;
    public Text dice;
    public int _dice;

    public Button throwDice;

    public Text resultat;
    public List<int> _resultat;
    public int resultatTotal;

    public bool canThrow = false;


    // Start is called before the first frame update
    void Start()
    {
        _resultat = new List<int>();   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ValidDice()
    {
        _nbDice = int.Parse(nbDice.text);
        _dice = int.Parse(dice.text);

        if ((_nbDice > 0) && (_dice > 0))
        {
            canThrow = true;
        }
        else
        {
            canThrow = false;
        }
    }

    public void ThrowDice()
    {
        ValidDice();
        if(canThrow)
        {
            resultatTotal = 0;
            _resultat = new List<int>();
            resultat.text = "resultat : ";
            for(int i = 0; i < _nbDice; i++)
            {
                _resultat.Add(Mathf.RoundToInt(Random.Range(1, _dice + 1)));
                resultatTotal += _resultat[i];

                if(_nbDice > 1 && i < _nbDice -1)
                {
                    resultat.text += _resultat[i].ToString();
                    resultat.text += " + ";
                }
                else if(i == _nbDice -1 && _nbDice > 1)
                {
                    resultat.text += _resultat[i].ToString();
                    resultat.text += " = ";
                }

            }
            resultat.text += resultatTotal.ToString();
        }
    }
}
