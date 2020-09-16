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
        print(text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
