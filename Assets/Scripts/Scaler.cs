using UnityEngine;
using DG.Tweening;
public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _endValueScale;
    [SerializeField] private float _durationScale;

    private void Start()
    {
        Scale();
    }

    private void Scale()
    {
        transform.DOScale(_endValueScale, _durationScale);
    }
}
