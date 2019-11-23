using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCard : MonoBehaviour
{
    public GameObject backCardPrefab;
    public GameObject frontCardPrefab;

    public GameObject MakeCardBackInstance()
    {
        return Instantiate(backCardPrefab);// as GameObject;
    }

    public GameObject MakeCardFrontInstance()
    {
        return Instantiate(frontCardPrefab);// as GameObject;
    }
}
