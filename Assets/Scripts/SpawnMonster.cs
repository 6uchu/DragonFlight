using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public GameObject monster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InvokeRepeating("함수이름",초기지연시간,지연할 시간);
        InvokeRepeating("MonsterSpawn", 0.5f, 5f);
    }

    // Update is called once per frame
    void MonsterSpawn()
    {
        //미사일 프리팹 , 런쳐포지션, 방향값 없음
        Instantiate(monster, transform.position, Quaternion.identity);
    }
}
