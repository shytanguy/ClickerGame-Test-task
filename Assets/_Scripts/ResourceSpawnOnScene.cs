using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResourceSpawnOnScene : MonoBehaviour
{

    [SerializeField] private ButtonWithTextScript _ButtonPrefab;

   

    [SerializeField] private ResourceSO[] _resourcesToSpawn;

    [SerializeField] private Transform _parentForButtons;

    private List<GameObject> _SpawnedButtons=new List<GameObject>();
   // [SerializeField] private Transform _parentForText;
    void Start()
    {
       for (int i=0; i<_resourcesToSpawn.Length; i++)
        {
            ButtonWithTextScript _button = Instantiate(_ButtonPrefab, _parentForButtons);
            _button.SetResource(_resourcesToSpawn[i]);

            _SpawnedButtons.Add(_button.gameObject);
       
        }
    }

 /*   private void OnValidate()
    {

        foreach(GameObject gameObject in _SpawnedButtons)
        {
            Destroy(gameObject);

        }

        for (int i = 0; i < _resourcesToSpawn.Length; i++)
        {
            ButtonWithTextScript _button = Instantiate(_ButtonPrefab, _parentForButtons);
            _button.SetResource(_resourcesToSpawn[i]);

        }
    }*/

}
