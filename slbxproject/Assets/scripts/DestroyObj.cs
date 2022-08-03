using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public Rigidbody body;
    public int force;
    public void WantToDestroy()
    {
        Destroy(this.gameObject);
    }
    public void AddForce()
    {
        body.AddRelativeForce(Vector3.up * 700);
    }
}
