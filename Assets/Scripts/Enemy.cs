using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    public GameObject explosionEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceY = -speed * Time.deltaTime;
        transform.Translate(0, distanceY, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            SoundManager.instance.SoundDie();

            Destroy(gameObject);
            Destroy(collision.gameObject);

            GameObject effect = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);

            GameManager.instance.AddScore(100);
        }

        if(collision.CompareTag("Player"))
        {
            SoundManager.instance.SoundDie();
            Destroy(collision.gameObject);
            GameObject effect = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
        }
    }
}
