using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    AudioSource myAudio;

    public AudioClip soundShoot;
    public AudioClip soundDie;
    private void Awake()
    {
        if (instance == null) instance = this;
        myAudio = GetComponent<AudioSource>();
    }
    public void SoundShoot()
    {
        myAudio.PlayOneShot(soundShoot);
    }
    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
}