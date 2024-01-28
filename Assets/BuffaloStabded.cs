using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffaloController : MonoBehaviour
{
    private Animator animator;
    public AudioClip deathSound;  // Reference to the death sound

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Call this method when the buffalo gets stabbed
    public void Stabbed()
    {
        // Trigger the "Stabbed" animation state
        animator.SetTrigger("Stabbed");

        // Play the death sound
        if (deathSound != null)
        {
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
        }

        // Start a coroutine to destroy the GameObject after the death animation finishes
        StartCoroutine(DestroyAfterAnimation());
    }

    // Coroutine to destroy the GameObject after the death animation finishes
    IEnumerator DestroyAfterAnimation()
    {
        // Get the length of the "Stabbed" animation clip
        AnimationClip clip = animator.GetCurrentAnimatorClipInfo(0)[0].clip;
        yield return new WaitForSeconds(clip.length);

        // Destroy the GameObject
        Destroy(gameObject);
    }
}