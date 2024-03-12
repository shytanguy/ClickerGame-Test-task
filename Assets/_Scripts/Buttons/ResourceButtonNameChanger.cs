using System;
using TMPro;
using UnityEngine;

/// <summary>
/// Класс для изменения имени кнопки на основе информации о ресурсе.
/// </summary>
public class ResourceButtonNameChanger : MonoBehaviour
{
    [SerializeField] private ResourceSO _resource;
    private TextMeshProUGUI _buttonNameText;

    private void Awake()
    {
        try
        {
            // Получаем компонент TextMeshProUGUI из дочерних объектов
            _buttonNameText = GetComponentInChildren<TextMeshProUGUI>();

            // Устанавливаем текст кнопки на основе названия ресурса
            _buttonNameText.text = _resource.Name;
        }
        catch (NullReferenceException e)
        {
            // Ловим исключение NullReferenceException и выводим его в консоль
            Debug.Log(e);
        }
    }
}