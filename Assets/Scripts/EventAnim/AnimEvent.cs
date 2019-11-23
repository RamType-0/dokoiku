using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvent : BaseAnimEvent
{
    public GameObject reachPrefab;
    public GameObject fishPrefab;
    public GameObject pushPrefab;
    public override void StartAnimEvent(GameObject _gameObject)
    {
        GameObject reachObject = Instantiate(reachPrefab) as GameObject;
        GameObject fishObject = Instantiate(fishPrefab) as GameObject;
        fishObject.GetComponent<SelfDestroyTimer>().enabled = true;
        _gameObject.GetComponent<FlipCard>().enabled = true;
    }

    public override void FinishFlip()
    {
        pushPrefab = Instantiate(pushPrefab) as GameObject;
    }
}
