using DG.Tweening;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] float _xEndValueMove;
    [SerializeField] float _durationMove;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMoveX(_xEndValueMove, _durationMove);
    }
}
