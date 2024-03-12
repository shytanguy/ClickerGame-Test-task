using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Класс для добавления ресурса при клике на кнопку.
/// </summary>
public class AddResourceScript : MonoBehaviour
{
    [SerializeField] private int _addOnClick = 1;
    [SerializeField] private ResourceSO _resource;

    private Button _resourceClickButton;

    private void Start()
    {
        _resourceClickButton = GetComponent<Button>();

        // Добавляем слушатель для события клика на кнопку
        _resourceClickButton.onClick.AddListener(AddResource);
    }

    /// <summary>
    /// Метод для добавления ресурса при клике на кнопку.
    /// </summary>
    private void AddResource()
    {
        // Увеличиваем значение ресурса на указанное количество
        _resource.AddValue(_addOnClick);
    }
}