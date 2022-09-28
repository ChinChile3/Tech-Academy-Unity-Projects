using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    public float speed;
    private Rigidbody rigBody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
        rigBody.AddForce(movement * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "GoalCylinder")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Collision Detected");
        }
    }
}
