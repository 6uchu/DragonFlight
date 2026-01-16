using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //입력값 받기
        float h = Input.GetAxis("Horizontal"); // A ,D   <- ,->

        //방향 벡터 생성
        Vector3 dir = new Vector3(h, 0, 0);

        //이동
        transform.Translate(dir * moveSpeed * Time.deltaTime);
    }
}
