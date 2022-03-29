using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devil_Trigger : MonoBehaviour
{
   // [SerializeField] GameObject DT;
    [SerializeField] GameObject Angel;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Collision Detected");        
            Destroy(Angel);
        }
    }

}
