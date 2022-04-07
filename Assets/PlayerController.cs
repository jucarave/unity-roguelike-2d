using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if (hor != 0 || ver != 0)
        {
            animator.SetFloat("Horizontal", hor);
            animator.SetFloat("Vertical", ver);
            animator.SetFloat("Speed", 1);

            Vector3 direction = (Vector3.up * ver + Vector3.right * hor).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
    }
}
