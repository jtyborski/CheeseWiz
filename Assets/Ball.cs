using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

   public GameObject wall;
    public GameObject hole;
    public Material LightUpMat;
   public Material StartMaterial;

    void Start()
    {
      
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hole")
        {
            wall.GetComponent<MeshCollider>().enabled = false;
            hole.GetComponentInChildren<Renderer>().sharedMaterial = LightUpMat;

        }
    }
        void OnTriggerExit(Collider other)
        {
            if (other.tag == "hole")
            {
                wall.GetComponent<MeshCollider>().enabled = true;
                hole.GetComponentInChildren<Renderer>().sharedMaterial = StartMaterial;
            }
        }
    }

