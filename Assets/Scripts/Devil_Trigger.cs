using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Devil_Trigger : MonoBehaviour
{
    [SerializeField] GameObject Angel;
    [SerializeField] private Material Switched_Wall_Material;
    [SerializeField] private AudioSource Devil_Music;
    [SerializeField] private AudioSource Angel_Music;



    private List<Wall> walls = new List<Wall>();

    void Start()
    {
        walls =
        FindObjectsOfType<Wall>()
        .Select(wall => wall)
        .ToList();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("Collision Detected");        
            Destroy(Angel);

            Angel_Music.Stop();
            Devil_Music.Play();
            
            foreach (Wall wall in walls) {

                wall.GetComponent<MeshRenderer>().material = Switched_Wall_Material;
                
            }
        }
    }

}
