using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kurssss;

/// <summary>
/// Класс, описывающий состояние рюкзака
/// </summary>
public class KnapsackState
{
    public List<Item> SelectedItems { get; set; }
  
    public List<Item> UnSelectedItems { get; set; }

    public int Capacity { get; set; }

    public int? SelectedWeight { get; set; }

    /// <summary>
    /// Конструктор состояния
    /// </summary>
    /// <param name="selectedItems"></param>
    /// <param name="totalWeight"></param>
    /// <param name="totalValue"></param>
    public KnapsackState(List<Item> selectedItems, List<Item> unSelectedItems, int capacity, int selectedWeight)
    {
        SelectedItems = selectedItems;
        UnSelectedItems = unSelectedItems;
        Capacity = capacity;
        SelectedWeight = selectedWeight;
    }

    public int GetSelectedValue()
    {
        int SelectedValue = 0;
        foreach(Item item in SelectedItems)
        {
            SelectedValue += item.Value;
        }
        return SelectedValue;
    }

    public KnapsackState Clone()
    {
        // Копируем все поля и создаем новые коллекции для SelectedItems и UnSelectedItems
        var selectedItemsCopy = new List<Item>(SelectedItems);
        var unselectedItemsCopy = new List<Item>(UnSelectedItems);
        return new KnapsackState(selectedItemsCopy, unselectedItemsCopy, Capacity, SelectedWeight ?? 0);
    }

    public void SaveToFile(string filePath)
    {
        var sb = new StringBuilder();

        // Сохраняем Capacity и SelectedWeight
        sb.AppendLine($"Capacity:{Capacity}");
        sb.AppendLine($"SelectedWeight:{SelectedWeight}");

        // Сохраняем выбранные предметы
        sb.AppendLine("SelectedItems:");
        foreach (var item in SelectedItems)
        {
            sb.AppendLine($"{item.Name};{item.Weight};{item.Value}");
        }

        // Сохраняем невыбранные предметы
        sb.AppendLine("UnSelectedItems:");
        foreach (var item in UnSelectedItems)
        {
            sb.AppendLine($"{item.Name};{item.Weight};{item.Value}");
        }

        File.WriteAllText(filePath, sb.ToString());
    }

    public static KnapsackState LoadFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        int capacity = 0;
        int? selectedWeight = null;

        var selectedItems = new List<Item>();
        var unselectedItems = new List<Item>();

        var section = ""; // Хранит текущую секцию: SelectedItems или UnSelectedItems

        foreach (var line in lines)
        {
            if (line.StartsWith("Capacity:"))
            {
                capacity = int.Parse(line.Split(':')[1]);
            }
            else if (line.StartsWith("SelectedWeight:"))
            {
                selectedWeight = int.Parse(line.Split(':')[1]);
            }
            else if (line == "SelectedItems:")
            {
                section = "SelectedItems";
            }
            else if (line == "UnSelectedItems:")
            {
                section = "UnSelectedItems";
            }
            else if (!string.IsNullOrWhiteSpace(line))
            {
                var parts = line.Split(';');
                var item = new Item(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));

                if (section == "SelectedItems")
                {
                    selectedItems.Add(item);
                }
                else if (section == "UnSelectedItems")
                {
                    unselectedItems.Add(item);
                }
            }
        }

        return new KnapsackState(selectedItems, unselectedItems, capacity, selectedWeight ?? 0);
    }
}

    //public string[] GetStateStringRepresentation()
    //{
    //    Capacity.ToString();
    //    SelectedWeight?.ToString();

    //}
    //public string GetKnapsackRepresentation()
    //{
    //    StringBuilder sb = new StringBuilder();

    //}

