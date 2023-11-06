//namespace
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour
{
    public float speed = -10;
    NewPlayer player;

    // Start is called before the first frame update
    void Start()    //처음 프로그램이 실행될 때만 시행
    {
        player = GameObject.Find(name: "Player").GetComponent<NewPlayer>();
    }

    // Update is called once per frame
    void Update()   //매 프레임마다 시행
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);   
        if (transform.position.x <-10)
        {
            player.addScore(1);
            Destroy(gameObject);
        }

    }

}
