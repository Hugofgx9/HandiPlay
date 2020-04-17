using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
<<<<<<< HEAD
=======
    public Text Count;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of 6562930... count
=======
>>>>>>> parent of 6562930... count
=======
>>>>>>> parent of 6562930... count

    public float m_speed = 100f;
    public Rigidbody2D m_rb2D;

    // Start is called before the first frame update
    void Start()
    {
        
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of 6562930... count
=======
>>>>>>> parent of 6562930... count
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "candy")
        {
            Destroy(collision.gameObject);
            m_CandyCount = m_CandyCount + 1;
            Count.text = m_CandyCount.ToString ();
        }
>>>>>>> parent of 6562930... count
    }

    // Update is called once per frame
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
