using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crop : MonoBehaviour
{
    [SerializeField] private float speed;
    public Transform target;
    public static int flag=0;
    

    private void Start() {
        target = FindObjectOfType<Bag>().GetComponent<Transform>();
    }
    private void Update() {
        if (Bag.crop_quantity <= 40)
        {
         
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            
        }
        
    }
    
}
