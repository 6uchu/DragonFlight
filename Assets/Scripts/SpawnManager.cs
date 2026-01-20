using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool ebabkeSpawn = false;
    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1f);
    }

    public void SpawnEnemy()
    {
        float randomX = Random.Range(-1.8f, 1.8f);
        if (ebabkeSpawn)
        {
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
        }
    }
}
