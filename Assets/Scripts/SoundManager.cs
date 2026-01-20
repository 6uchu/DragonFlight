using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;


    AudioSource myAudio;

    public AudioClip soundBullet; //재생할 소리 변수
    public AudioClip soundDie; //죽는 사운드

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
    }
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    public void SoundDie()
    {
        myAudio.PlayOneShot(soundDie);
    }
    public void SoundBullet()
    {
        myAudio.PlayOneShot(soundBullet);
    }
}
