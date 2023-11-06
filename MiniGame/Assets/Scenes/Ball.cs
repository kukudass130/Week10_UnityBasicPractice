using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed = -10;
    //Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(ballSpeed * Time.deltaTime, 0, 0);
        if (transform.position.x < -10 ) 
            Destroy(gameObject);
    }
    NewPlayer newP;
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);
        //GetComponent보다 tryGetComponent를 사용할 것을 추천.
        if(collision.gameObject.GetComponent<NewPlayer>() != null)
        {
            Debug.Log("aa");
            newP = (NewPlayer)collision.gameObject.GetComponent<NewPlayer>();
            newP.addScore(1);
            Destroy(gameObject);
            
        }
    }


}
