using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Apple : MonoBehaviour
{
    public TMP_Text AppleCounter;
    public void AppleEaten()
    {
        GameObject AppleCounter = GameObject.FindWithTag("AppleCounter");
        UICounter counter = AppleCounter.GetComponent<UICounter>();
        counter.AddToCounter(1);

    
        
            if(AppleCounter != null && counter.counter == 20)
            {
                GameManager.instance.Win();
            }
        



       
    }
}
