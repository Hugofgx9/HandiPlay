using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("GoLeft", true);
        } else
        {

            animator.SetBool("GoLeft", false);

        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("GoRight", true);
        }
        else
        {

            animator.SetBool("GoRight", false);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetBool("GoDown", true);
        }
        else
        {

            animator.SetBool("GoDown", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("GoUp", true);
        }
        else
        {

            animator.SetBool("GoUp", false);
        }


    }
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.left);
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.right);
        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.up);
        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            m_rb2D.MovePosition(m_rb2D.position + Time.fixedDeltaTime * m_speed * Vector2.down);
        }
    }

}