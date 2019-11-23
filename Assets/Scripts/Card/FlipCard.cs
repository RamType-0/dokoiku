using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour
{
    float flipSpeed = 0.2f;
    //float time = 0.0f;
    public void Start()
    {
        enabled = false;   
    }
    public void Update()
    {
        //time += Time.deltaTime;

        if (transform.localEulerAngles.y <= 89.0f)
        {
            transform.Rotate(0.0f, flipSpeed, 0.0f);
        }
        else
        {
            GameObject.Find("CardManager").GetComponent<CardManager>().TellFinishFlip(this.gameObject);
            Destroy(this);
        }
    }
}
