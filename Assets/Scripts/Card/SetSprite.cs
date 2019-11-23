using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSprite : MonoBehaviour
{
    SpriteRenderer mySpriteRenderer;
    int imageNum;
    [SerializeField] Sprite[] allImages;
    public int SetSpriteRandom()
    {
       // Sprite[] allImages = Resources.LoadAll<Sprite>("Texture");

        int allImageLength = allImages.Length;

        int imageNum = Random.Range(0, allImageLength - 1);

        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = allImages[imageNum];

        return imageNum;
    }

    public void SetSpriteSpecification( int specNum )
    {
        //Sprite[] allImages = Resources.LoadAll<Sprite>("Texture");

        mySpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = allImages[specNum];
    }
}
