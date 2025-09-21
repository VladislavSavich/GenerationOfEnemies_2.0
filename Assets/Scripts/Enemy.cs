using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private float _speed = 2f;
    private Vector3 _direction;

    private void Update()
    {
        _direction = (_target.Position - transform.position).normalized;
        transform.position += _direction * _speed * Time.deltaTime;
        transform.rotation = Quaternion.LookRotation(_direction);
    }

    public void SetTarget(Target target) 
    {
        _target = target;
    }
}
