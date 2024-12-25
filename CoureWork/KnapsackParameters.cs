using System;

namespace Kurssss;

/// <summary>
/// Класс для передачи начальных параметров
/// </summary>
public class KnapsackParameters
{
    public int Capacity { get; set; }

   

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="backpack_capacity">Вместимость рюкзака</param>
    /// <param name="number_of_objects">Количество объектов</param>\

    public KnapsackParameters(int capacity)
    {
        Capacity = capacity;
    }
}