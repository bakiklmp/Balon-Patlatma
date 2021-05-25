using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonGenerator : MonoBehaviour
{
    public GameObject essahBalon;
    public float balonXEkseni = 10;
    public float balonYEkseni = -5;
    public float balonZEkseni = 0;
    
    void Start()
    {
        
        /*for(int i = 0; i < 10; i++)
        {
            essahBalon.gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            itemGenerator();
        }*/
            

    }
    void Update()
    {
        essahBalon.gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        itemGenerator();
    }
    void itemGenerator()
    {
        Vector3 randPosition = new Vector3(Random.Range(-balonXEkseni, balonXEkseni), Random.Range(-balonYEkseni, balonYEkseni), (balonZEkseni));
        GameObject klon = Instantiate(essahBalon, randPosition, Quaternion.identity);
        
    }
}
