using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.UpArrow;
    public KeyCode moveDown = KeyCode.DownArrow;
    public KeyCode moveLeft = KeyCode.LeftArrow;
    public KeyCode moveRight = KeyCode.RightArrow;

    public static PlayerController instance;
    
    Rigidbody rb;

    public float moveForce = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);

        }
        else
        {
            Destroy(gameObject);
        }
        
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetKeyDown(moveUp))
        {
            rb.AddForce(Vector3.up * moveForce);
        }

        if (Input.GetKeyDown(moveDown))
        {
            rb.AddForce(Vector3.down * moveForce);
        }
        if (Input.GetKeyDown(moveLeft))
        {
            rb.AddForce(Vector3.left * moveForce);
        }
        if (Input.GetKeyDown(moveRight))
        {
            rb.AddForce(Vector3.right * moveForce);
        }
    }


}
