using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTransition : Transition
{
    [SerializeField] private float _rangeSpread;

    private float _transitionRange;

    private void Start()
    {
        _transitionRange = Random.Range(0, _rangeSpread);
    }
    
    private void Update()
    {
        if(Vector2.Distance(transform.position, Target.transform.position) < _transitionRange)
            NeedTransit = true;
    }
}
