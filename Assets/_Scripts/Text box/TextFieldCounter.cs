using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

/// <summary>
/// Абстрактный класс TextFieldCounter предоставляет базовую функциональность для работы с текстовым счётчиком
/// </summary>
public abstract class TextFieldCounter : MonoBehaviour
{
    /// <summary>
    /// Ссылка на текстовое поле.
    /// </summary>
   [SerializeField] protected TextMeshProUGUI _textField;

    /// <summary>
    /// Начальный текст для текстового поля.
    /// </summary>
    [SerializeField] protected string _initialText;


    private void Awake()
    {
        GetTextField();

        CheckValue();
    }

    /// <summary>
    /// Метод для получения ссылки на текстовое поле.
    /// </summary>
    protected void GetTextField()
    {
        // Пытаемся получить компонент TextMeshProUGUI из объекта.
        TryGetComponent<TextMeshProUGUI>(out _textField);

        // Если компонент не найден, выводим сообщение об ошибке в консоль.
        if (_textField == null)
        {
            Debug.Log("Отсутствует компонент текстового поля");
            return;
        }
    }

    /// <summary>
    /// Абстрактный метод для установки нового значения в текстовое поле.
    /// </summary>
    /// <param name="value">Новое значение для текстового поля.</param>
    protected abstract void SetNewValue(int value);

    /// <summary>
    /// Абстрактный метод для проверки значения, которое необходимо выставить в текстовом поле.
    /// </summary>
    protected abstract void CheckValue();

    /// <summary>
    /// Метод для изменения текста в текстовом поле на основе переданного числа.
    /// </summary>
    /// <param name="number">Число, которое будет отображено в текстовом поле.</param>
    protected void ChangeTextValue(int number)
    {
        try
        {
            // Изменяем текст текстового поля на основе начального текста и переданного числа.
            _textField.text = $"{_initialText}: {number}";
        }
        catch (NullReferenceException e)
        {
            // Выводим сообщение об ошибке в случае возникновения исключения 
            Debug.Log(e);
        }
    }
}