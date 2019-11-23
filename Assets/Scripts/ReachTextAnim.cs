using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReachTextAnim : MonoBehaviour
{
    float slideSpeed = 0.2f;
    float time = 0.0f;
    bool countFlag = false;
    private void Start()
    {
        transform.localPosition = new Vector3(6.0f, 0.0f,0.0f);
    }

    private void Update()
    {
        if(transform.localPosition.x > 0.1f)
        {
            transform.Translate(-slideSpeed, 0.0f, 0.0f);
        }
        if(transform.localPosition == Vector3.zero)
        {
            if (transform.GetChild(0).gameObject.activeInHierarchy== false)
            {
                transform.GetChild(0).gameObject.SetActive(true);
            }
            countFlag = true;
        }
        if((this.time >= 1.0f) && (transform.localPosition.x > -6.0f))
        {
            transform.Translate(-slideSpeed, 0.0f, 0.0f);
        }
        if(this.time > 3.0f)
        {
            Destroy(this.gameObject);
        }

        if(countFlag == true)
        {
            this.time += Time.deltaTime;
        }
    }
}
