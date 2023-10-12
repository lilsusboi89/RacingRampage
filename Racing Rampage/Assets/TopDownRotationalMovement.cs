using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class TopDownRotationalMovement: MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float moveSpeed = 5.0f;
    float turnSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = transform.up * y * moveSpeed * Time.deltaTime * 60;
        transform.Rotate(0, 0, -x * Time.deltaTime * 60 * turnSpeed);

    }
}
