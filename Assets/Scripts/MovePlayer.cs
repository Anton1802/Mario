using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    private float playerSpeed = 5.0f;
    private float jumpPower = 5.0f;

    public Rigidbody2D player;

    private void Jump() => player.velocity = new Vector2(0, jumpPower);



    private void Move()
    {

        var horizontal = Input.GetAxisRaw("Horizontal");

        SpriteRenderer sprite = GetComponent<SpriteRenderer>();

        if(Input.GetKey(KeyCode.A))
        {

            sprite.flipX = true;

        }
        else if(Input.GetKey(KeyCode.D))
        {

            sprite.flipX = false;

        }

        player.velocity = new Vector2(horizontal * playerSpeed, player.velocity.y);

    }

    void Update()
    {

        Move();

        if(Input.GetKey(KeyCode.Space))
        Jump();

    }



}
