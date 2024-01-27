using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 0.5f; // Adjust the speed as needed
     private Animator anim;
    private Vector3 originalScale; 
    // Start is called before the first frame update
    void Start()
    {
        originalScale= new Vector3(1,1,1);
        anim = gameObject.GetComponent<Animator>();
        //anim.Play("standing");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(horizontalInput, 0, 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        // Flip the player character horizontally if moving left
        if (horizontalInput < 0)
        {
            anim.SetBool("walk", true);
            transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.z);
        }
        // Flip the player character horizontally if moving right
        else if (horizontalInput > 0)
        {
            anim.SetBool("walk", true);
            transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.z);
        }
        else{
            anim.SetBool("walk", false);
        }
    }
}
