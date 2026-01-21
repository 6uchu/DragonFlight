using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject enemy;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2.0f, 1.5f);
    }


    void SpawnEnemy()
    {
        Instantiate(enemy, new Vector3(Random.Range(-1.9f, 1.9f), 6f, 0), Quaternion.identity);
    }
}
