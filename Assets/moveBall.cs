using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveBall : MonoBehaviour
{
    public Rigidbody rd;
    public float moveSpeed = 300f; // f is nessesary, must be some kind of unit

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate () {

        rd.AddForce(0,0, moveSpeed * Time.deltaTime);
        
    }
}
