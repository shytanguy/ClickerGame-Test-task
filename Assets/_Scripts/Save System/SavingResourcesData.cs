using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// ����� ��� ���������� ���������� ������������ ������� � PlayerPrefs
/// </summary>
public class SavingResourcesData : MonoBehaviour
{
    /// <summary>
    /// ������, ���������� �������� ���������� ���������
    /// </summary>
    [SerializeField] private ResourceSO _resourceToSave;
    private void Start()
    {   
      _resourceToSave.SetValue(PlayerPrefs.GetInt(_resourceToSave.Name, 0));
    }
    private void OnEnable()
    {
        _resourceToSave.ValueChanged += SaveOnAmountChanged;
    }
    private void OnDisable()
    {
        _resourceToSave.ValueChanged -= SaveOnAmountChanged;
    }
    public void SetResource(ResourceSO resource)
    {

        _resourceToSave.ValueChanged -= SaveOnAmountChanged;

        _resourceToSave = resource;

        _resourceToSave.ValueChanged += SaveOnAmountChanged;

        _resourceToSave.SetValue(PlayerPrefs.GetInt(_resourceToSave.Name, 0));
    }
    /// <summary>
    /// �����, ����������� ���������� �������
    /// </summary>
    private void SaveOnAmountChanged(int amount)
    {
        PlayerPrefs.SetInt(_resourceToSave.Name, amount);
        PlayerPrefs.Save();
    }
}
