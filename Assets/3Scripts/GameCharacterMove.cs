using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCharacterMove : MonoBehaviour
{
    public float speed = 0.5f;
    SpriteRenderer spriteRenderer;
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(h, 0, 0);
        transform.position += dir * speed * Time.deltaTime;

        Debug.Log(h);

        if (Input.GetButtonDown("Horizontal"))
        spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;

        if(h == 0)
        {
            anim.SetBool("isRun", false);
        }else if(h != 0)
        {
            anim.SetBool("isRun", true);
        }
    }
}
