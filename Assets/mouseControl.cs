using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseControl : MonoBehaviour
{
    public float sensitivity = 1f;
    private bool isMouseControlEnabled = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            isMouseControlEnabled = true;
        }

        if(Input.GetMouseButtonUp(0)){
            isMouseControlEnabled = false;
        }

        if(isMouseControlEnabled){

        float mouseX = Input.GetAxis("Mouse X") * sensitivity;

        transform.Translate(new Vector3(mouseX, 0f, 0f));
        }
    }


}
