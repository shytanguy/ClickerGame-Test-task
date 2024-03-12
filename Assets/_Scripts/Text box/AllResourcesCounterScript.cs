using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// Класс для подсчета и отображения общего количества ресурсов.
/// </summary>
public class AllResourcesCounterScript : TextFieldCounter
{
    [SerializeField] private ResourceSO[] resourcesToCount;

    private void OnEnable()
    {
        foreach (ResourceSO resource in resourcesToCount)
        {
            // Подписываемся на событие изменения значения ресурса для каждого ресурса в списке
            resource.ValueChanged += SetNewValue;
        }
    }

    private void OnDisable()
    {
        foreach (ResourceSO resource in resourcesToCount)
        {
            // Отписываемся от события изменения значения ресурса для каждого ресурса в списке
            resource.ValueChanged -= SetNewValue;
        }
    }

    protected override void SetNewValue(int number)
    {
        CheckValue();
    }

    protected override void CheckValue()
    {
        int totalAmount = 0;
        foreach (ResourceSO resource in resourcesToCount)
        {
            // Суммируем общее количество ресурсов
            totalAmount += resource.Amount;
        }

        // Обновляем текстовое значение суммарного количества ресурсов
        ChangeTextValue(totalAmount);

    }
}