using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0f, rotationSpeed, 0f);
        // 위 코드로 실행시 비정상적으로 빠른 회전!
        //각 컴퓨터마다 1초당 찍는 프레임이 다르기 때문에 Update 프레임에 대한 간격을 고려해야한다.
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
