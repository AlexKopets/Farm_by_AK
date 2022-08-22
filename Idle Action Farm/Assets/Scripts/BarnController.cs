using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarnController : MonoBehaviour
{
    GameObject[] gameObjects;
    public Text pointText;
    public static int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Crop");
        if (other.CompareTag("Bag"))
        {
            Bag.crop_quantity--;
            point = point + 15;
            pointText.text = point+"";
            if(Bag.crop_quantity == 0)
            {
                for (int i = 0; i < gameObjects.Length; ++i)
                {
                    Destroy(gameObjects[i]);
                }
            }
        }
        
    }
}
