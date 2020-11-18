using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // 총알을 생산
    public GameObject firePosition; // 총구

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")) // 플레이어가 발사버튼을 누르면
        {
            GameObject bullet = Instantiate(bulletFactory); // 총알 공장에서 총알을 만들고, 
            bullet.transform.position = firePosition.transform.position; // 총알을 발사한다.
        }
    }
}
