using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Canon"))
        {
            GData.isAttacked = true;
        } 
    }

    private void Attack()
    {
        if (GData.isAttacked == true)
        {

        }
    }
}
