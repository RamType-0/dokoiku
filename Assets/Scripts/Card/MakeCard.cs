using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCard : MonoBehaviour
{
    public GameObject backCardPrefab;
    public GameObject frontCardPrefab;

    public GameObject MakeCardBackInstance()
    {
        GameObject backCard = Instantiate(backCardPrefab) as GameObject;
        return backCard;
    }

    public GameObject MakeCardFrontInstance()
    {
        GameObject frontCard = Instantiate(frontCardPrefab) as GameObject;
        return frontCard;
    }
}
