using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(distanceX, 0, 0);
    }
}
