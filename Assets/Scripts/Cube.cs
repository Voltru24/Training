using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{
    [SerializeField] Vector3 _endValueRotate;
    [SerializeField] float _durationRotate;
    [SerializeField] Vector3 _endValueScale;
    [SerializeField] float _durationScale;
    [SerializeField] Vector3 _EndValueMove;
    [SerializeField] float _durationMove;

    private void Start()
    {
        Rotate();
        Scale();
        Move();
    }

    private void Rotate()
    {
        transform.DOLocalRotate(_endValueRotate, _durationRotate);
    }

    private void Scale()
    {
        transform.DOScale(_endValueScale, _durationScale);
    }

    private void Move()
    {
        transform.DOMove(_EndValueMove, _durationMove);
    }
}
