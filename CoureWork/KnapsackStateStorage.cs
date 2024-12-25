using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

/// <summary>
/// Класс-Хранилище
/// </summary>
public class KnapsackStateStorage
{


    public List<KnapsackState> _storage;
    public KnapsackStateStorage()
    {
        _storage = new List<KnapsackState>();
    }

    public int Count => _storage.Count;

    public void AddState(KnapsackState state)
    {
        if (state == null)
        {
            return;
        }
        if (_storage.Count > 0 && _storage.Last().Equals(state))
        {
            _storage.RemoveAt(_storage.Count - 1);
        }
        _storage.Add(state);
    }

    public KnapsackState GetState(int index)
    {
        if (_storage[index] == null || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        return _storage[index];
    }

    public int GetStorageLenght()
    {
        return _storage.Count;
    }

    public void SaveToFile(string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            foreach (var state in _storage)
            {
                // Сохраняем каждое состояние в формате текста с разделителями
                writer.WriteLine("StateStart");
                writer.WriteLine($"Capacity:{state.Capacity}");
                writer.WriteLine($"SelectedWeight:{state.SelectedWeight}");
                writer.WriteLine("SelectedItems:");
                foreach (var item in state.SelectedItems)
                {
                    writer.WriteLine($"{item.Name};{item.Weight};{item.Value}");
                }
                writer.WriteLine("UnSelectedItems:");
                foreach (var item in state.UnSelectedItems)
                {
                    writer.WriteLine($"{item.Name};{item.Weight};{item.Value}");
                }
                writer.WriteLine("StateEnd");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        var newStates = new List<KnapsackState>();

        List<Item> selectedItems = null;
        List<Item> unselectedItems = null;
        int capacity = 0;
        int? selectedWeight = null;
        bool isReadingSelectedItems = false;

        foreach (var line in lines)
        {
            if (line == "StateStart")
            {
                // Инициализируем списки для нового состояния
                selectedItems = new List<Item>();
                unselectedItems = new List<Item>();
            }
            else if (line.StartsWith("Capacity:"))
            {
                capacity = int.Parse(line.Split(':')[1]);
            }
            else if (line.StartsWith("SelectedWeight:"))
            {
                selectedWeight = int.Parse(line.Split(':')[1]);
            }
            else if (line == "SelectedItems:")
            {
                isReadingSelectedItems = true;
            }
            else if (line == "UnSelectedItems:")
            {
                isReadingSelectedItems = false;
            }
            else if (line == "StateEnd")
            {
                if (selectedItems == null || unselectedItems == null || selectedWeight == null)
                {
                    throw new InvalidOperationException("Некорректная структура файла.");
                }

                // Завершаем чтение одного состояния и добавляем его в коллекцию
                newStates.Add(new KnapsackState(selectedItems, unselectedItems, capacity, selectedWeight.Value));
            }
            else if (!string.IsNullOrWhiteSpace(line))
            {
                // Парсим строку с данными предмета
                var parts = line.Split(';');
                if (parts.Length != 3)
                {
                    throw new FormatException($"Неверный формат строки: {line}");
                }

                var item = new Item(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));

                if (isReadingSelectedItems)
                {
                    selectedItems?.Add(item);
                }
                else
                {
                    unselectedItems?.Add(item);
                }
            }
        }

        // Проверяем, что хотя бы одно состояние было добавлено
        if (newStates.Count == 0)
        {
            throw new InvalidOperationException("Файл не содержит ни одного состояния.");
        }

        // Заменяем текущие состояния новыми
        _storage = newStates;
    }

}
//public void SaveToFile(string filePath)
//{
//    using (StreamWriter writer = new StreamWriter(filePath))
//    {
//        foreach (var state in _storage)
//        {
//            // Сохраняем состояние как строку с разделителями
//            string line = $"{state.Capacity}|{state.SelectedWeight}|{state.GetSelectedValue()}|";
//            foreach (var item in state.Items)
//            {
//                line += $"{item.Weight},{item.Value};"; // Записываем предметы через запятую, а между предметами ставим точку с запятой
//            }
//            writer.WriteLine(line.TrimEnd(';')); // Удаляем последнюю точку с запятой
//        }
//    }
//}
