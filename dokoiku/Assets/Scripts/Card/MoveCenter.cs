using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenter : MonoBehaviour
{
    float slideSpeed = 0.1f;

    void Start()
    {
        enabled = false;
    }

    void Update()
    {
        if(transform.position.x > 0.1f)
        {
            transform.Translate(-slideSpeed, 0, 0);
        }
        else if (transform.position.x < -0.1f)
        {
            transform.Translate(slideSpeed, 0, 0);
        }

        if (transform.position.y > 0.1f)
        {
            transform.Translate(0, -slideSpeed, 0);
        }
        else if (transform.position.y < -0.1f)
        {
            transform.Translate(0, slideSpeed, 0);
        }

        if(transform.position.sqrMagnitude <= 0.01f)
        {
            transform.localPosition = Vector3.zero;
            GameObject.Find("CardManager").GetComponent<CardManager>().TellStartAnim(this.gameObject);
            enabled = false;
        }
    }
}
