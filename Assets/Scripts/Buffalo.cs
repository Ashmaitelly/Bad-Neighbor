using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bufallo : MonoBehaviour
{
    public float moveSpeed = 0.5f; // Adjust the speed as needed
     private Animator anim;
    
    private Vector3 originalScale; 
    // Start is called before the first frame update
    void Start()
    {
        originalScale= new Vector3(1,1,1);
        anim = gameObject.GetComponent<Animator>();
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
