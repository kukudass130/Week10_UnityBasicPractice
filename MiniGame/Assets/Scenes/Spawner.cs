using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] wallPrefab;
    public GameObject dropPrefab;
    public float BallSpeed = -30;
    public GameObject ballPrepab;
    public float interval = 1.5f;
    public float range = 3;
    float term;
    // Start is called before the first frame update
    void Start()
    {
        term = interval;
    }

    // Update is called once per frame
    void Update()
    {
        term += Time.deltaTime;
        if (term >= interval)    //일정시간이 지나면
        {
            Vector3 pos = transform.position;
            pos.y += Random.Range(-range, range);   //정수형이면 range에 2가 들어갈 수 있다.(3.0 불가)
            int wallType = Random.Range(0, wallPrefab.Length);
            Instantiate(wallPrefab[wallType], pos, transform.rotation);
            //if (Random.Range(0, 2) == 0) //50퍼 확률로 떨어지는 장애물 생성
            //    Instantiate(dropPrefab);
            if (Random.Range(0, 2) == 0) //50퍼 확률로 던지는 장애물 생성
                Instantiate(ballPrepab, pos, transform.rotation);
            term -= interval;
        }
    }
}
