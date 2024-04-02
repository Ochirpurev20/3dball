using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDetection : MonoBehaviour
{
public gameOverObjects gameOverObjects;
   
public int coin = 0;
    // Start is called before the first frame update
    void Start()
    {
    print("started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GameOver(){
         print("Game over!");
        Time.timeScale = 0f;
        gameOverObjects.Setup(coin);
    }
    private void OnCollisionEnter(Collision other){
          if(other.transform.tag == "road"){
            print("Zam deer hurev");
        }
         if(other.transform.tag == "zoos"){
            coin++;
            print("Coin murguv. coin ==");
            print(coin);
            Destroy(other.gameObject);
        }
        if(other.transform.tag == "saad"){
        GameOver();
        }
         
    }
     private void OnCollisionExit(Collision other){
          if(other.transform.tag == "road"){
            GameOver();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "zoos"){
            coin++;
            print("Coin murguv. coin ==");
            print(coin);
            Destroy(other.gameObject);
        }
        if(other.transform.tag == "saad"){
        GameOver();
        }
    }
}
