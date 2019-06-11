using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    private int hpMax;
    private int hpCurrent; 
    private int armor;
    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()

    {
        
    }


    void TakeDammage(int dmg)
    {
        hpCurrent-= dmg -armor;
        hpCurrent = hpCurrent < 0 ? 0 : hpCurrent;
     
    }

    void Heal(int hp)
    {
        hpCurrent += hp;
        hpCurrent = hpCurrent > hpMax ? hpMax : hpCurrent;

    }
}

