using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody sphereRigidbody;


    private void Awake()
    {
        sphereRigidbody = GetComponent<Rigidbody>();

    }



    public void up()
    {

        Debug.Log("Up!");
        sphereRigidbody.AddForce(Vector3.up * 1f, ForceMode.Impulse);
    }



    public void Left()
    {

        Debug.Log("Left!");
        sphereRigidbody.AddForce(Vector3.right * 1f, ForceMode.Impulse);
    }

    public void Right()
    {

        Debug.Log("Right!");
        sphereRigidbody.AddForce(Vector3.left * 1f, ForceMode.Impulse);
    }

    public void down()
    {

        Debug.Log("Down!");
        sphereRigidbody.AddForce(Vector3.down * 1f, ForceMode.Impulse);
    }

    public void forward()
    {

        Debug.Log("Forward!");
        sphereRigidbody.AddForce(Vector3.down * 10f, ForceMode.Impulse);
    }

    public void Transparency()
    {
        Debug.Log("Transparency+!");
        GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 200f);
    }
    public void Transdecrease()
    {
        Debug.Log("Transparency-!");
        GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }
    public void speedincrease()
    {
        Debug.Log("hury!");
        GetComponent<ParticleSystem>().startSpeed = 10.0F;
    }
    public void speeddecrease()
    {
        Debug.Log("hold on!");
        GetComponent<ParticleSystem>().startSpeed = 0.0F;
    }

    public void degreeincrease()
    {
        Debug.Log("degree+!");
        GetComponent<ParticleSystem>().startSpeed = 15F;
    }
    public void degreedecrease()
    {
        Debug.Log("degree-!");
        GetComponent<ParticleSystem>().startSpeed = -5F;
    }
    
}