using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class GardenController : MonoBehaviour
{
    private Animator gardenAnim;
    public GameObject crop;
    private float stopTime = 0;
   
    void Start()
    {
        gardenAnim = GetComponent<Animator>();
       
    }

    
    void Update()
    {
        if(stopTime > 0)
        {
            stopTime -= Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(stopTime <= 0)
        {
            if(Bag.crop_quantity <= 40)
            {
                if (other.CompareTag("Player"))
                {
                    gardenAnim.SetTrigger("GardenRun");
                    Instantiate(crop);
                    stopTime = 10;
                    Bag.crop_quantity++;
                }
            }
            
        }
    }
}
