using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideThis : MonoBehaviour
{
    float hideSpeed = 0.05f;

    void Start()
    {
        this.GetComponent<HideThis>().enabled = false;
    }

    void Update()
    {
        this.transform.localScale = new Vector3(
            this.transform.localScale.x - hideSpeed,
            this.transform.localScale.y - hideSpeed,
            this.transform.localScale.z );

        if(this.transform.localScale.x <= 0)
        {
            GameObject.Find("CardManager").GetComponent<CardManager>().DestroyCard(this.gameObject);
            enabled = false;
        }
    }
}
