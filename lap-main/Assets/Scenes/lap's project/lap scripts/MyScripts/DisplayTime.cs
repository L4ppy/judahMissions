using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayTime: MonoBehaviour
{
    
    public TMP_Text TimerTxt;
    public int TimeHolder;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TimeGoDown());
    }

    IEnumerator TimeGoDown()
    {
        while (TimeHolder >= 0)
        {
            TimerTxt.text = TimeHolder.ToString();

            yield return new WaitForSeconds(1f);
            
            if (TimeHolder < 15) TimerTxt.color = Color.red;

            TimeHolder--;
            
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    timeToDisplay = "time: " + timeScript.
    //}
   


}
