﻿using UnityEngine;
using UnityEngine.UI;

public class ComupteNumbers : MonoBehaviour
{
    public Text result;
    public InputField varA;
    public InputField varB;
    public Button btn_reset;
    public Button btn_sub_Numbers;

    public void SetResult()
    {
        result.text = SubNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        btn_sub_Numbers.interactable = false;
        btn_reset.interactable = true;
    }

    public void Reset()
    {
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        btn_sub_Numbers.interactable = true;
        btn_reset.interactable = false;
        result.text = "Result";
    }
    private int SubNumbers()
    {
        int tempResult = int.Parse(varA.text) - int.Parse(varB.text);
        return tempResult;
    }
}
