using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public Sprite backGroundSprite;
    public GameObject endText;
    public GameObject restartCanvas;
    public MakeCard cardGenerator;
    public CardManager cardManager;
    public SpriteRenderer bgRenderer;
    public void ShowResult()
    {
        var frontCard = cardGenerator.MakeCardFrontInstance();
        int thisResult = frontCard.GetComponent<SetSprite>().SetSpriteRandom();
        cardManager.DestroyAllCard();
        cardManager.ExcutionADDCardList(frontCard);
        bgRenderer.sprite = backGroundSprite;
        Instantiate(restartCanvas);
        Instantiate(endText);
        new SaveData().saveResult(thisResult);
    }
}
