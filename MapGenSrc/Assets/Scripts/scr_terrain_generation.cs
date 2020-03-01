using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_terrain_generation : MonoBehaviour
{
    public GameObject obj_house;

    private const int num_houses = 10;
    private float width = 10.0f;
    private float height = 3.0f; 
    
    // Start is called before the first frame update
    void Start()
    {
        // create houses 
        for (int i = 0; i < num_houses; ++i) {
            Vector3 position = new Vector3(Random.Range(-width,width), Random.Range(-height,height), 0);
            Instantiate(obj_house, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
