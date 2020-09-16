using System.Collections;
using System.Collections.Generic;
using UnityEngine; // 네임 스페이스

public class Coding : MonoBehaviour // 상위 클래스
{
    // Start is called before the first frame update
    // 유니티가 호출해주는 두 개의 함수
    void Start() // 만들어질 때 한 번 호출됨
    {
        string text;

        text = "Hello World!";
        Debug.Log(text);

        int number = 6;
        if(number <= 0)
        {
            print("값이 0보다 작습니다.");
        } else if(number >= 1 && number <= 5)
        {
            print("값이 1~5의 값입니다.");
        } else
        {
            print("값이 5보다 큽니다.");
        }
    }

    // Update is called once per frame
    void Update() // 매 프레임 호출된다. 초당 60번 실행하면 계속 호출됨
    {
        
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if(theCollision.gameObject.name == "Floor")
        {
            Debug.Log("Hit the floor!");
        } else if(theCollision.gameObject.name == "Cube1")
        {
            Debug.Log("Hit the Cube1!");
            Destroy(GameObject.Find("Cube1"), 0);
        }
        
    }
}
