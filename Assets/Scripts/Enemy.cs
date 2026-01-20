using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1f;
    void Start()
    {
        SingletonTest.instance.EnemySound();
    }

    // Update is called once per frame
    void Update()
    {
        //이동
        transform.Translate(0 ,-1 * moveSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            SoundManager.Instance.SoundDie();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
