using UnityEngine;

[RequireComponent(typeof(Alarm))]
public class Home : MonoBehaviour
{
    private Alarm _alarm;

    void Start()
    {
        _alarm = GetComponent<Alarm>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rogue>())
        {
            _alarm.Run();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Rogue>())
        {
            _alarm.Stop();
        }
    }
}
