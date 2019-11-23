using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCard : MonoBehaviour
{
    GameObject cardList;

    void Start()
    {
        this.cardList = GameObject.Find("CardList");
    }

    public void HideOtherCard()
    {
        int listElement = cardList.GetComponent<CardList>().CountCardList();
        for(int i = 0; i < listElement; i++)
        {
            if(cardList.GetComponent<CardList>().ReadCardList(i).GetComponent<CardPrefab>().CheckBtnFlag())
            {
                
            }
            else
            {
                cardList.GetComponent<CardList>().ReadCardList(i).GetComponent<HideThis>().enabled = true;
            }
        }
    }
}
