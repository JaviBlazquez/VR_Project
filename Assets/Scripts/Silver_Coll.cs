using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silver_Coll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Segundo")
        {
            GameManager.Instance.contador++;
            collision.gameObject.SetActive(false);
        }
    }
}
