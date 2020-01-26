using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaBehaviour : MonoBehaviour
{
    Rigidbody2D pizzaBody;
    // Start is called before the first frame update
    void Start()
    {
        pizzaBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            pizzaBody.velocity = new Vector2(0, -50);
        }
    }
}
