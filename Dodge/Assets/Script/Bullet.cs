using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward *speed;
        //trasform.forward는 오브젝트의 앞방향을 Vector3의 형태로 변환. z축 화살표의 방향이 forward의 방향.
        Destroy(gameObject, 3f); //3초 뒤에 파괴.
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
