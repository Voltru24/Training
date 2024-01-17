using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    private Transform _transformGoal;

    [SerializeField] private float _speed;

    public void SetTransformGoal(Transform transformGoal)
    {
        _transformGoal = transformGoal;
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 direction = (_transformGoal.position - transform.position).normalized;

        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
