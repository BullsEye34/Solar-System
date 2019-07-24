using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{

    public float speed;
    public Transform sun;
    void Update()
    {
        if(sun!=null){
      transform.RotateAround(sun.position, Vector3.up, Time.deltaTime * speed);  
      }
      else{
          Debug.Log("Sun Is Absent");
      }
    }
}
