using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Sprite UpidleSprite;
    public Sprite DownidleSprite;
    public Sprite SideidleSprite;
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
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("direction", 0);
            animator.SetBool("isMoving", true);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("isMoving", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("direction", 2);
            animator.SetBool("isMoving", true);
            spriteRenderer.flipX = true;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isMoving", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("direction", 1);
            animator.SetBool("isMoving", true);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("isMoving", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("direction", 2);
            animator.SetBool("isMoving", true);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isMoving", false);
        }
    }
}
