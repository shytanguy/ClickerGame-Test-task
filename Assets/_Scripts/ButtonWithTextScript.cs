using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonWithTextScript : MonoBehaviour
{

    [SerializeField] private GameObject _button;

    [SerializeField] private ResourceCounterScript _counterScript;

    [SerializeField] private ResourceSO _resource;
    public void SetResource(ResourceSO resource)
    {

        _resource = resource;

        _button.GetComponent<AddResourceScript>().SetResource(resource);

        _button.GetComponent<ResourceButtonNameChanger>().SetResource(resource);

        _button.GetComponent<SavingResourcesData>().SetResource(resource);

        _button.GetComponent<AddResourcePerTime>().SetResource(resource);

        _counterScript.SetResource(resource);
    }


    private void Start()
    {
        if (_resource != null);
        SetResource(_resource);
    }
}
