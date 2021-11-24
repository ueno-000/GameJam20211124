using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoerText;
    [SerializeField] int moneyScoer = 0;
    //GamaManager gamaManager = default;
    bool live;
    
    void Start()
    {
        scoerText.color = new Color(1, 1, 1, 1);
        //gamaManager = GetComponent<GamaManager>();
    }

    void Update()
    {
        scoerText.text = "MONEY " + moneyScoer.ToString("D10");
        if (moneyScoer >= 10 && moneyScoer < 100) scoerText.color = new Color(0, 1, 0, 1);
        else if (moneyScoer >= 100 && moneyScoer < 1000) scoerText.color = new Color(0, 0, 1, 1);
        else if (moneyScoer >= 1000 && moneyScoer < 10000) scoerText.color = new Color(1, 0, 1, 1);
        else if (moneyScoer >= 10000 && moneyScoer < 100000) scoerText.color = new Color(1, 0.92f, 0.016f, 1);
        else if (moneyScoer >= 100000&& moneyScoer < 1000000) scoerText.color = new Color(1, 0, 0, 1);
    }
}
