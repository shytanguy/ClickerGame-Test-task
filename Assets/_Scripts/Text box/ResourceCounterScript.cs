using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

/// <summary>
/// ����� ��� ����������� ���������� ������������� �������.
/// </summary>
public class ResourceCounterScript : TextFieldCounter
{
    [SerializeField] private ResourceSO _resourceToCount;

    protected override void SetNewValue(int value)
    {
        // ��������� ��������� �������� �������� �������
        ChangeTextValue(value);
    }
    public void SetResource(ResourceSO resource)
    {
        _resourceToCount.ValueChanged -= SetNewValue;

        _resourceToCount = resource;

        _initialText = resource.Name;
        

        ChangeTextValue(_resourceToCount.Amount);

        _resourceToCount.ValueChanged += SetNewValue;

    }


    private void OnEnable()
    {
        if (_resourceToCount != null)
        {
            // ������������� �� ������� ��������� �������� �������
            _resourceToCount.ValueChanged += SetNewValue;
        }
    }
    protected override void CheckValue()
    {
        SetNewValue(_resourceToCount.Amount);
    }
    private void OnDisable()
    {
        if (_resourceToCount != null)
        {
            // ������������ �� ������� ��������� �������� �������
            _resourceToCount.ValueChanged -= SetNewValue;
        }
    }
}