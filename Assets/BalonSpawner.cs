using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonSpawner : MonoBehaviour
{
    public GameObject balonPrefab;
    public float spawnsuresi = 1;
    private Vector2 cameraBound;
    void Start()
    {
        cameraBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(balonDalgasi());
        
    }
    private void balonCikar()
    {
        GameObject klonBalon = Instantiate(balonPrefab) as GameObject ;
        klonBalon.transform.position = new Vector2(Random.Range(-cameraBound.x,cameraBound.x),-cameraBound.y *2);
        
    }
    IEnumerator balonDalgasi()
    {
        while (true)// oyunun baþlamasý ve bitmesi için bu booleaný deðiþken olarak yap
        {
            
            yield return new WaitForSeconds(spawnsuresi);
            balonCikar();
        }
    }  
   
}
