using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    public AudioSource audioSource;

    private void Awake()
    {
        
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSource.Play();
    }
}
