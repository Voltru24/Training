using UnityEngine;
using DG.Tweening;
public class Capsule : MonoBehaviour
{
    [SerializeField] Vector3 _endValueScale;
    [SerializeField] float _durationScale;

    private void Start()
    {
        Scale();
    }

    private void Scale()
    {
        transform.DOScale(_endValueScale, _durationScale);
    }
}
