using System;
using UnityEngine;

/// <summary>
/// ����� ScriptableObject ��� �������� ���������� � �������, ��� ��������, ����������, � ����� �������� �������, ������������� ��� ��������� �������� ���������� �������
/// </summary>
[CreateAssetMenu(fileName = "Resource", menuName = "Scriptable Objects/Resource")]
public class ResourceSO : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField]   private int _amount;


    /* 
     1 ������� 1 �������
    2 ������� 1 ������
     */
    [SerializeField] private float _TimeDelay=1;

    public float TimeDelay
    {
        get { return _TimeDelay; }
        private set
        {
            _TimeDelay = value;
        
        }
    }
    /// <summary>
    /// ���������� �������.
    /// </summary>
    public int Amount
    {
        get { return _amount; }
        private set
        {
            _amount = value;
            ValueChanged?.Invoke(_amount);
        }
    }

    /// <summary>
    /// �������, ������������� ��� ��������� �������� ���������� �������
    /// </summary>
    public event Action<int> ValueChanged;

    /// <summary>
    /// ����������� �������� ���������� ������� �� ��������� ����������.
    /// </summary>
    /// <param name="amount">���������� ��� ���������� � �������� �������� ���������� �������.</param>
    public void AddValue(int amount)
    {
        Amount += amount;
    }
    /// <summary>
    /// ������������� �������� ���������� �������
    /// </summary>
    /// <param name="amount">���������� ��� ������������ �������� ���������� �������.</param>
    public void SetValue(int amount)
    {
        Amount = amount;
    }

    
    /// <summary>
    /// �������� �������.
    /// </summary>
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }
}