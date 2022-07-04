using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{

    private float playerSpeed = 5.0f;
    private float jumpPower = 5.0f;

    public Rigidbody2D player;
    public LayerMask groundLayer;
    public float distance;

    private void Jump() => player.velocity = new Vector2(0, jumpPower);

    private bool isGrounded()
    {

        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if(hit.collider != null)
        {

            return true;
        }

        return false;

    }

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

        if(Input.GetKey(KeyCode.Space) && isGrounded())
        Jump();

    }

    void OnTriggerEnter2D(Collider2D other)
    {

            SceneManager.LoadScene("Menu");

    }



}
