using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSprite : MonoBehaviour
{
    SpriteRenderer mySpriteRenderer;
    int imageNum;

    public int SetSpriteRandom()
    {
        Sprite[] imageAll = Resources.LoadAll<Sprite>("Texture");

        int allImageLength = imageAll.Length;

        int imageNum = Random.Range(0, allImageLength - 1);

        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = imageAll[imageNum];

        return imageNum;
    }

    public void SetSpriteSpecification( int specNum )
    {
        Sprite[] imageAll = Resources.LoadAll<Sprite>("Texture");

        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = imageAll[specNum];
    }
}
