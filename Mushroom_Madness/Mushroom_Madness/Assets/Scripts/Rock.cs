using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public TMP_Text RockCounter;
    public void RockHit()
    {
        GameObject RockCounter = GameObject.FindWithTag("RockCounter");
        UICounter counter = RockCounter.GetComponent<UICounter>();
        counter.AddToCounter(1);

        if (RockCounter != null && counter.counter == 3)
        {
            GameManager.instance.Lose();   
        }
    }
}
