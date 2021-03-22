using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    private GameObject target;


    private void Start()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Property>().Ctype == this.gameObject.GetComponent<Property>().Ctype && collision.gameObject.GetComponent<Property>().CVal != this.gameObject.GetComponent<Property>().CVal)
        {
            Debug.Log("Collided");
            int sumCval = collision.gameObject.GetComponent<Property>().CVal + this.gameObject.GetComponent<Property>().CVal;
            Debug.Log("sum="+sumCval);
            

            if(sumCval == gameObject.GetComponent<Property>().combo1.GetComponent<Property>().CVal)
            {
                target = gameObject.GetComponent<Property>().combo1.gameObject;
            }
            else
            {
                target = gameObject.GetComponent<Property>().combo2.gameObject;
            }


            if(sumCval >6)
            {
                target = gameObject.GetComponent<Property>().combo1.gameObject;
            }

            Instantiate(target, collision.transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
            Destroy(this.gameObject);



        }
    }
}
