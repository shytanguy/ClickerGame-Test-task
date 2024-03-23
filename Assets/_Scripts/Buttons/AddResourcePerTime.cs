using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddResourcePerTime : MonoBehaviour
{
    [SerializeField] private ResourceSO _resource;

    [SerializeField] private int _valueToAdd;

    private float _Timer;

    private float _Time;

    
   
    private void Update()
    {
        int toAdd=0;

       while (Time.time - _Timer >= _resource.TimeDelay)
        {
            toAdd += _valueToAdd;
         
            
            _Timer +=_resource.TimeDelay;
            
        }
        _resource.AddValue(toAdd);
    }
  
    
    
    public void SetResource(ResourceSO resource)
    {
        _resource = resource;

    }
   
  
   
}
