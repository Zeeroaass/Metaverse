using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(moveX, moveY, 0).normalized;
        transform.position += move * Time.deltaTime * 5f;

        bool isMoving = move != Vector3.zero;
        animator.SetBool("isMoving", isMoving);
        if (isMoving)
        {
            if (moveY > 0)
            {
                animator.SetInteger("direction", 0);
                spriteRenderer.flipX = false;
            }
            else if (moveY < 0)
            {
                animator.SetInteger("direction", 1);
                spriteRenderer.flipX = false;
            }
            else if (moveX < 0)
            {
                animator.SetInteger("direction", 2);
                spriteRenderer.flipX = true;
            }
            else if (moveX > 0)
            {
                animator.SetInteger("direction", 2);
                spriteRenderer.flipX = false;
            }
        }
    }

    void LateUpdate()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -7.8f, 7.5f);
        pos.y = Mathf.Clamp(pos.y, -4.1f, 3.5f);

        transform.position = pos;
    }
}
