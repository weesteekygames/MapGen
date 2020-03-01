using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_town_properties : MonoBehaviour
{
    private string m_town_name;
    private int m_population; 

    // mentality
    enum Menatily { PEACEFUL = 0, WARLIKE = 1 };
    private int m_mentality_int;
    private Menatily m_mental;

    // Start is called before the first frame update
    void Start()
    {
        if(Random.Range(0, 100) < 50)
        {
            m_mentality_int = 1;
        }
        else
        {
            m_mentality_int = 0;
        }

        Debug.Log(m_mentality_int);
        m_mental = (Menatily)m_mentality_int;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
