using System;
using UnityEngine;

/// <summary>
/// Класс ScriptableObject для хранения информации о ресурсе, его названии, количестве, а также содержит событие, срабатывающее при изменении значения количества ресурса
/// </summary>
[CreateAssetMenu(fileName = "Resource", menuName = "Scriptable Objects/Resource")]
public class ResourceSO : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField]   private int _amount;


    /* 
     1 секунда 1 серебро
    2 секунды 1 золото
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
    /// Количество ресурса.
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
    /// Событие, срабатывающее при изменении значения количества ресурса
    /// </summary>
    public event Action<int> ValueChanged;

    /// <summary>
    /// Увеличивает значение количество ресурса на указанное количество.
    /// </summary>
    /// <param name="amount">Количество для добавления к текущему значению количества ресурса.</param>
    public void AddValue(int amount)
    {
        Amount += amount;
    }
    /// <summary>
    /// устанавливает значение количества ресурса
    /// </summary>
    /// <param name="amount">Количество для установления значения количества ресурса.</param>
    public void SetValue(int amount)
    {
        Amount = amount;
    }

    
    /// <summary>
    /// Название ресурса.
    /// </summary>
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }
}