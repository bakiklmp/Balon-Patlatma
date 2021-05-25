using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    [SerializeField] public GameObject renkliBalon; //serializeField private olan bir deðiþkeni de arayüzden deðiþebilmeni saðlar
    [SerializeField] public float hiz = 10;
    private Rigidbody2D rb;
    private Vector2 cameraBound;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, hiz);
        cameraBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        renkliBalon.gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        tiklaPatlat();

        if (transform.position.y > cameraBound.y * 2)
        {
            Destroy(this.gameObject);
        }
    }
    private void tiklaPatlat()
    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.gameObject == gameObject) Destroy(gameObject);
            }
        }

        /*if (Input.GetMouseButton(0))
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            // Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //   Vector2 mousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition), Camera.main.ScreenToWorldPoint(Input.mousePosition));
            RaycastHit2D hit = Physics2D.Raycast(worldPosition,Vector2.zero);
            if (hit.collider != null)
            {
                Destroy(this.gameObject);

            }
        }
    }*/

    }
}

