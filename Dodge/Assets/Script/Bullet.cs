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
        //trasform.forward�� ������Ʈ�� �չ����� Vector3�� ���·� ��ȯ. z�� ȭ��ǥ�� ������ forward�� ����.
        Destroy(gameObject, 3f); //3�� �ڿ� �ı�.
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
