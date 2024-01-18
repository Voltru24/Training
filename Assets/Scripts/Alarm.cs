using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _maxVolume;
    [SerializeField] private float _speedVolume;

    private float _minVolume = 0;
    private AudioSource _audioSource;
    private bool _isPenetration = false;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Rogue>())
        {
            _isPenetration = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Rogue>())
        {
            _isPenetration = false;
        }
    }

    private void FixedUpdate()
    {
        if (_isPenetration == true)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolume, _speedVolume * Time.deltaTime);
        }
        else
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _minVolume, _speedVolume * Time.deltaTime);
        }
    }
}
