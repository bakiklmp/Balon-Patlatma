using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiklaPatlat : MonoBehaviour
{
    public GameObject balon;
    void Update()
    {
       
    }
    /*private void tiklaPatlat()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //   Vector2 mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.ScreenToWorldPoint(Input.mousePosition));
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(this.gameObject);

            }
        }
    }*/

}
