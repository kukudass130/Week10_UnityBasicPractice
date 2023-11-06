using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;    //�̵� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        //GetComponent<>() ���ϴ� ���� ������Ʈ�� ������Ʈ���� �������� �޼ҵ�.
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.UpArrow) == true)  //== true �� ������ �� �ִ�.
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

        float xInput = Input.GetAxis("Horizontal");     //Input.GetAxis�� � �࿡ ���� �Է°��� ���ڷ� ��ȯ�ϴ� �޼ҵ�
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.velocity = newVelocity;
    }


    public void Die()
    {
        gameObject.SetActive(false);    
        //SetActive�� ���ӿ�����Ʈ�� Ȱ��ȭ�� ��Ȱ��ȭ�� �����ϴ� �޼ҵ�. ���� ����� ������ ������ ����.
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();

    }
}
