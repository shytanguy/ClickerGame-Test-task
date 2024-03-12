using System;
using UnityEngine;

/// <summary>
///  ласс ScriptableObject дл€ хранени€ информации о ресурсе, его названии, количестве, а также содержит событие, срабатывающее при изменении значени€ количества ресурса
/// </summary>
[CreateAssetMenu(fileName = "Resource", menuName = "Scriptable Objects/Resource")]
public class ResourceSO : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField]   private int _amount;

    /// <summary>
    ///  оличество ресурса.
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
    /// —обытие, срабатывающее при изменении значени€ количества ресурса
    /// </summary>
    public event Action<int> ValueChanged;

    /// <summary>
    /// ”величивает значение количество ресурса на указанное количество.
    /// </summary>
    /// <param name="amount"> оличество дл€ добавлени€ к текущему значению количества ресурса.</param>
    public void AddValue(int amount)
    {
        Amount += amount;
    }

    /// <summary>
    /// Ќазвание ресурса.
    /// </summary>
    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }
}