using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChangeTrigger : MonoBehaviour
{

    public Material changeToMaterial; //Reference to the material

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Get the renderer component
        Renderer render = GetComponent<Renderer>();

        //Set the material to changeToMaterial object
        render.material = changeToMaterial;
    }
}
