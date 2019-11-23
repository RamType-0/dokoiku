using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPrefab : MonoBehaviour
{
    int cardNum = 0;
    bool btnFlag = false;


    public void OnBtnFlag()
    {
        this.btnFlag = true;
    }

    public bool CheckBtnFlag()
    {
        return btnFlag;
    }

    public void ADDCardNum(int x)
    {
        this.cardNum = x;
    }

    public int ReadCardNum()
    {
        return cardNum;
    }
}
