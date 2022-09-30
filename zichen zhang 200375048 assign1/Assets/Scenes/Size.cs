using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Size : MonoBehaviour
{
    void start() { }

    public void SizeUp(){
        Debug.Log("+!");
        transform.localScale = new Vector3(2,2,2);
        }
    public void SizeDown()
    {
        Debug.Log("-!");
        transform.localScale = new Vector3(1, 1, 1);
    }
    }

