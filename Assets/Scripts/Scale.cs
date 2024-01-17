using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speedScale;

    public void FixedUpdate()
    {
        Up();
    }

    public void Up()
    {
        Vector3 vectorScale = transform.localScale;

        vectorScale += new Vector3(_speedScale, _speedScale, _speedScale) * Time.deltaTime;

        transform.localScale = vectorScale;
    }
}
