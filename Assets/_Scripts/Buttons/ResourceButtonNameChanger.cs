using System;
using TMPro;
using UnityEngine;

/// <summary>
/// ����� ��� ��������� ����� ������ �� ������ ���������� � �������.
/// </summary>
public class ResourceButtonNameChanger : MonoBehaviour
{
    [SerializeField] private ResourceSO _resource;
    [SerializeField]  private TextMeshProUGUI _buttonNameText;

    private void Awake()
    {
        if (_buttonNameText==null)
        GetButtonText();
    }

    public void SetResource(ResourceSO resource)
    {
        _resource = resource;
        if (_buttonNameText == null)
        {
            GetButtonText();
        }
        _buttonNameText.text = _resource.Name;
    }

    private void GetButtonText()
    {
        try
        {
            // �������� ��������� TextMeshProUGUI �� �������� ��������
            _buttonNameText = GetComponentInChildren<TextMeshProUGUI>();

            // ������������� ����� ������ �� ������ �������� �������
            _buttonNameText.text = _resource.Name;
        }
        catch (NullReferenceException e)
        {
            // ����� ���������� NullReferenceException � ������� ��� � �������
            Debug.Log(e);
        }
    }
}