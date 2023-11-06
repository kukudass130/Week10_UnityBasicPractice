using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;    //이동 속도

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //GetComponent<>() 원하는 게임 오브젝트의 컴포넌트값을 가져오는 메소드.
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.UpArrow) == true)  //== true 는 생략할 수 있다.
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true )
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }*/

        float xInput = Input.GetAxis("Horizontal");     //Input.GetAxis는 어떤 축에 대한 입력값을 숫자로 반환하는 메소드
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.velocity = newVelocity;
    }


    public void Die()
    {
        gameObject.SetActive(false);    
        //SetActive는 게임오브젝트의 활성화와 비활성화를 결정하는 메소드. 씬에 존재는 하지만 보이지 않음.
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();

    }
}
