using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverObjects : MonoBehaviour
{
    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Setup(int score){
        gameObject.SetActive(true);
          if(pointsText != null){
        pointsText.text = score.ToString();
        } else {
            Debug.LogWarning("onoonii sambar zaagdaagui bn");
        }
    }
}
