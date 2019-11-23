using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public GameObject CardPrefab;
    GameObject cardList;
    float span = 0.2f;
    float time = 0.2f;
    int cardNum = 0;

    void Start()
    {
        this.cardList = GameObject.Find("CardList");
    }

    // Update is called once per frame
    void Update()
    {
        this.time += Time.deltaTime; 
        if( this.time > this.span )
        {
            this.time = 0;
            if( this.cardNum < 5 )
            {
                GameObject card = Instantiate(CardPrefab) as GameObject;
                card.GetComponent<CardPrefab>().ADDCardNum(cardNum);
                Vector3 cardVector = new Vector3(6.0f, 0.0f, 0.0f);
                card.GetComponent<SlideObject>().enabled = true;

                switch ( cardNum )
                {
                    case 0:
                        cardVector.x += (-1.5f);
                        cardVector.y += 3;
                        card.transform.position = cardVector;
                        break;
                    case 1:
                        cardVector.x += 1.5f;
                        cardVector.y += 3;
                        card.transform.position = cardVector;
                        break;
                    case 2:
                        cardVector.x += 0.0f;
                        cardVector.y += 0.0f;
                        card.transform.position = cardVector;
                        break;
                    case 3:
                        cardVector.x += (-1.5f);
                        cardVector.y += (-3);
                        card.transform.position = cardVector;
                        break;
                    case 4:
                        cardVector.x += 1.5f;
                        cardVector.y += (-3);
                        card.transform.position = cardVector;
                        break;

                }

                cardList.GetComponent<CardList>().ADDCardList(card);

                cardNum++;
            }
            else
            {
                enabled = false;
            }
        }
    }
}
