using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public LayerMask collisionMask;

    public Transform pointOne;
    public Transform pointTwo;

    public float moveTime = 1;
    private float moveSpeed;
    private Vector2 maximumDistance;

    private Rigidbody2D rb;
    private Transform moveToPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (moveTime == 0f)
        {
            moveTime = 1f;
        }

        moveToPoint = pointTwo;
        moveSpeed = Vector3.Distance(pointOne.position, pointTwo.position) / moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 distanceRemaining = moveToPoint.position - transform.position;
        maximumDistance = distanceRemaining.normalized * moveSpeed * Time.fixedDeltaTime;

        if (maximumDistance.magnitude >= distanceRemaining.magnitude || distanceRemaining.magnitude == 0f)
        {
            maximumDistance = distanceRemaining;

            //swap points
            if (moveToPoint == pointOne)
            {
                moveToPoint = pointTwo;
            }
            else
            {
                moveToPoint = pointOne;
            }
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition((Vector2)transform.position + maximumDistance);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collisionMask == (collisionMask | (1 << collision.gameObject.layer)))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collisionMask == (collisionMask | 1 << collision.gameObject.layer))
        {
            collision.transform.SetParent(null);
        }
    }
}
