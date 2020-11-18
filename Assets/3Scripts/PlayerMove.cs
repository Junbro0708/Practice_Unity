using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f; // public을 붙여주면 유니티에서 해당 값을 보고 수정할 수 있다.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        print("h: " + h + "v: " + v);

        //Vector3 dir = Vector3.right * h + Vector3.up * v; // 방법1
        //transform.Translate(dir * speed * Time.deltaTime); // 방법1

        Vector3 dir = new Vector3(h, v, 0); // 방법2 : P = P0 + vt
        transform.position += dir * speed * Time.deltaTime; // 방법2

        //transform.Translate(Vector3.up * speed * Time.deltaTime); // 1초에 5미터가도록 코드
        //transform은 이동 회전 변환을 담당하는 컴포넌트, Translate는 이 스크립트가 붙어있는 객체가 움직이게끔 한다.
        // Vector3 = (1,0,0) / deltaTime은 업데이트 될때마다 시간차이로 계속 업데이트
    }
}
