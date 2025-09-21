using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float _speed = 2f; 
    private float _distance = 20;
    private float _offset;
    private Vector3 _startPosition;
    public Vector3 Position => transform.localPosition;

    private void Start()
    {
        _startPosition = transform.localPosition;
    }

    private void Update()
    {
        _offset = Mathf.PingPong(_speed * Time.time, _distance);
        transform.localPosition = _startPosition + Vector3.forward * _offset;
    }
}
