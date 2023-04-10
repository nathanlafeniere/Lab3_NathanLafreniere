using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    [SerializeField] private float _amplitude = 1;
   
    Vector3 _positionInitiale;
     private float _vitesse = 10;

    private void Start()
    {
        _positionInitiale= transform.position;
     
    }
    // Update is called once per frame
    private void Update()
    {

         if (transform.position.y >= 10)
        {
            _amplitude = -1;
        }
        else if (transform.position.y <= 0.6)
        {
            _amplitude = 1;
        }
        
            transform.position = transform.position + new Vector3(0f, _vitesse * _amplitude * Time.deltaTime , 0f);
    }
}
