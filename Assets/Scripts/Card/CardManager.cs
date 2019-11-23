using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    const float CARD_SIZE_X = 0.73f;
    const float CARD_SIZE_Y = 1.3f;
    GameObject cardList;

    private void Start()
    {
        cardList = GameObject.Find("CardList");
    }

    public void ExcutionADDCardList(GameObject _card)
    {
        cardList.GetComponent<CardList>().ADDCardList(_card);
    }

    public bool CardChoiceEvent(Vector3 _mousePos)
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(_mousePos);
        bool sucCardChoiceFlag = false;

        int listElement = cardList.GetComponent<CardList>().CountCardList();
        GameObject[] card = new GameObject[listElement];
        bool[] cardChoiceFlag = new bool[listElement];

        for (int i = 0; i < listElement; i++)
        {
            cardChoiceFlag[i] = false;
            card[i] = cardList.GetComponent<CardList>().ReadCardList(i);
            Vector3 cardPos = card[i].transform.position;
            if ((mousePos.x >= (cardPos.x - CARD_SIZE_X)) && (mousePos.x <= (cardPos.x + CARD_SIZE_X)))
            {
                if ((mousePos.y >= (cardPos.y - CARD_SIZE_Y)) && (mousePos.y <= (cardPos.y + CARD_SIZE_Y)))
                {
                    card[i].GetComponent<CardPrefab>().OnBtnFlag();
                    cardChoiceFlag[i] = true;
                    sucCardChoiceFlag = true;
                }
            }

        }

        if (sucCardChoiceFlag)
        {
            for (int i = 0; i < listElement; i++)
            {
                if (!card[i].GetComponent<CardPrefab>().CheckBtnFlag())
                {
                    card[i].GetComponent<HideThis>().enabled = true;
                }
                else
                {
                    card[i].GetComponent<MoveCenter>().enabled = true;
                }
                card[i] = null;
            }
        }

        return sucCardChoiceFlag;
    }

    public void DestroyCard(GameObject card)
    {
        cardList.GetComponent<CardList>().RemoveCard(card);
        Destroy(card);
    }

    public void DestroyAllCard()
    {
        int listElement = cardList.GetComponent<CardList>().CountCardList();
        while (listElement > 0)
        {
            GameObject card = cardList.GetComponent<CardList>().ReadCardList(0);
            cardList.GetComponent<CardList>().RemoveCard(card);
            Destroy(card);
            listElement--;
        }
    }

    public void TellStartAnim(GameObject _gameObject)
    {
        GameObject.Find("AnimManager").GetComponent<StartAnim>().ExcutionStartAnim(_gameObject);
    }
    public void TellFinishFlip(GameObject _gameObject)
    {
        GameObject.Find("AnimManager").GetComponent<StartAnim>().ExcutionFinishFlip(_gameObject);
    }

    //メモ用：カードサイズを取得する
    //SpriteRenderer spriteRenderer = cardList.GetComponent<CardList>().readCardList(i).GetComponent<SpriteRenderer>();
    //Bounds bounds = spriteRenderer.bounds;
    //Vector3 vector3 = bounds.size;

    //float x = vector3.x;
    //Debug.Log(x);
    //            float y = vector3.y;
    //Debug.Log(y);
    //            float z = vector3.z;
    //Debug.Log(z);
}
