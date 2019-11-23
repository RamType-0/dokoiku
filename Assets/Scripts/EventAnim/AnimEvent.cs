using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvent : BaseAnimEvent
{
    public GameObject reachPrefab;
    public SelfDestroyTimer fishPrefab;
    public GameObject pushPrefab;
    public override void StartAnimEvent(GameObject _gameObject)
    {
        Instantiate(reachPrefab);
        var fishTimer = Instantiate(fishPrefab);
        fishTimer.enabled = true;
        _gameObject.GetComponent<FlipCard>().enabled = true;
    }

    public override void FinishFlip()
    {
        Instantiate(pushPrefab);
    }
}
