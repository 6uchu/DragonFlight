using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Shoot", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Shoot()
    {
        SoundManager.instance.SoundShoot();
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
