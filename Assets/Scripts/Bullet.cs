using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject effect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject go = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(go, 1f);

            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
    //화면 이탈 시 파괴
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
