using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Vector2 moveVelocity;
    public Rigidbody2D rb;
    public bool isInLife;
    public GameObject bullet;
    Vector2 bulletPos;
    public float fireRate = 0.0f;
    float nextFire = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isInLife = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInLife == true)
        {
            Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            moveVelocity = moveInput.normalized * moveSpeed;
        }

        if (Input.GetMouseButton(0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Fire();
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }


    void Fire()
    {
        /*bulletPos = transform.position;
        bulletPos += new Vector2(+1f, 0f);
        Instantiate(bullet, bulletPos, Quaternion.identity);*/

    }

}
