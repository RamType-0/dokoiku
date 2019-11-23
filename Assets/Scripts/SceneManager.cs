using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public Sprite backGroundSprite;
    public GameObject endText;
    public GameObject restartCanvas;
    public void ResultScreen()
    {
        GameObject frontCard = GameObject.Find("CardGenerator").GetComponent<MakeCard>().MakeCardFrontInstance();
        int thisResult = frontCard.GetComponent<SetSprite>().SetSpriteRandom();
        GameObject cardManager = GameObject.Find("CardManager");
        cardManager.GetComponent<CardManager>().DestroyAllCard();
        cardManager.GetComponent<CardManager>().ExcutionADDCardList(frontCard);

        GameObject BGObject = GameObject.Find("BG");
        BGObject.GetComponent<SpriteRenderer>().sprite = backGroundSprite;

        restartCanvas = Instantiate(restartCanvas) as GameObject;
        endText = Instantiate(endText) as GameObject;

        SaveData mySaveData = new SaveData();
        mySaveData.saveResult(thisResult);
    }
}
