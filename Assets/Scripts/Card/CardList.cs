using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardList : MonoBehaviour
{
    List<GameObject> cardList = new List<GameObject>();

    public void ADDCardList( GameObject card )
    {
        this.cardList.Add(card);
    }

    public GameObject ReadCardList( int x )
    {
        return cardList[x];
    }

    public int CountCardList()
    {
        return cardList.Count;
    }

    public void RemoveCard(GameObject card)
    {
        cardList.Remove(card);
    }
}
