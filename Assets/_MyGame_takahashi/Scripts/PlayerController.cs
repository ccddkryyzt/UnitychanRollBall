using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    private float moveHorizontal;
    private float moveVertical;
    private Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //inputはUpdate
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        //動かすのはfixedUpdate
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        // アイテムゲット
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
