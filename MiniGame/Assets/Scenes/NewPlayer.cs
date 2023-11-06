using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    //public float playerSpeed = 0.3f;
    public float jumpPower = 5;
    public float jumpboost = 2;
    public float low = -3;
    public float tall = 0.1f;
    TextMesh scoreOutput;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreOutput = GameObject.Find(name: "Score").GetComponent<TextMesh>();
        //이름으로 게임 오브젝트 찾고 그중 TextMesh 컴포넌트를 얻기
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale += new Vector3(0, tall*Time.deltaTime, 0);   //점점 길어지는 플레이어
        //transform.Translate(playerSpeed * Time.deltaTime, 0, 0);  //점점 이동하는 플레이어
        if (Input.GetButtonDown("Jump"))
        {    //유니티에서 space바는 Jump로 정의 되어 있음.
            //Debug.Log("aa");
            if (transform.position.y <= low)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower * jumpboost, 0);
                //일정 높이 아래에서 점프 부스터
            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)  //충돌시 재시작
    {
        if (collision.gameObject.GetComponent<Wall>() != null)
        {
            Debug.Log("들어감");
        }



        //SceneManager.LoadScene(SceneManager.GeActiveScene().name);
    }

    //점수 더하기
    public void addScore(int s)
    {
        score += s;
        scoreOutput.text = "Score: " + score;
    }
}
