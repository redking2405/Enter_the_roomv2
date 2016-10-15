using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour
{

    [SerializeField]
    private float Speed = 5.0f;
    private Rigidbody rb;
    private Animator anim;

    private Vector3 direction;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //en avant
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.Z))
        {
            direction += Speed * Vector3.forward;
            anim.SetFloat("Speed", Mathf.Abs(0.3f));
        }

        //en arrière
        if (Input.GetKey(KeyCode.S))
        {
            direction += Speed * -Vector3.forward;
            anim.SetFloat("Speed", Mathf.Abs(0.3f));//rb.velocity.x));
        }
        else if (rb.velocity.x<0)
            anim.SetFloat("Speed", Mathf.Abs(0.0f));

        gameObject.transform.position += direction * Speed * Time.deltaTime;
    }
}