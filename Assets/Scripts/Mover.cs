using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _xEndValueMove;
    [SerializeField] private float _durationMove;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMoveX(_xEndValueMove, _durationMove);
    }
}
