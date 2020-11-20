using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Patika : MonoBehaviour
{
    public bool temasEdildiMi;
    public GameObject borular;

    
    // Start is called before the first frame update
    void Start()
    {
        //0.157 0.68
    }

    // Update is called once per frame
    void Update()
    {
        if (temasEdildiMi)
        {
           
            Invoke("IleriAta", 3f);
            temasEdildiMi = false;
        }
    }

    void IleriAta()
    {
        transform.position = transform.position + new Vector3(6, 0, 0);
        float yPoz = Random.Range(0.157f, 0.68f);

        borular.transform.localPosition = new Vector3(0, yPoz,0);
       
    }
}
