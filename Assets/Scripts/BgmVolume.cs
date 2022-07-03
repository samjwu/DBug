using UnityEngine;

public class BgmVolume : MonoBehaviour
{
    public AudioSource BgmPlayer;

    public float Volume = 1f;

    void Start()
    {
        BgmPlayer = GetComponent<AudioSource>();
    }

    void Update()
    {
        BgmPlayer.volume = Volume;        
    }

    public void SetVolume(float volume)
    {
        this.Volume = volume;
    }
}
