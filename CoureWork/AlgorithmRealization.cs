using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

/// <summary>
/// Класс, реализующий алгоритм
/// </summary>
public class AlgorithmRealization
{
    private List<Item> selectedItems = new List<Item>();

    private List<Item> unSelecteditems;

    private int capacity;

    private int selectedWeight = 0;

    private KnapsackParameters parameters;
    
    


    public AlgorithmRealization(int capacity)
    {
        this.capacity = capacity;

        unSelecteditems = new List<Item>();
    }

    /// <summary>
    /// Жадный алгоритм
    /// </summary>
    /// <returns></returns>
    public void StepSolve()
    {
        List<Item> sortedItems = unSelecteditems;

        sortedItems.Sort((x, y) => (y.Value / y.Weight).CompareTo(x.Value / x.Weight));
        unSelecteditems = sortedItems;

        selectedWeight += sortedItems[0].Weight;

        selectedItems.Add(sortedItems[0]);
    
       // sortedItems.RemoveAt(0);
        unSelecteditems.RemoveAt(0);
    }

    public void SetState(KnapsackState state)
    {
        selectedItems = state.SelectedItems;
        unSelecteditems = state.UnSelectedItems;
        capacity = state.Capacity;
       // selectedWeight = state.SelectedWeight;
    }

    public KnapsackState SaveKnapsackState()
    {
        var selCopy = new List<Item>(selectedItems);
        var unSelCopy = new List<Item>(unSelecteditems);

        return new KnapsackState(selCopy, unSelCopy, capacity, selectedWeight);
    }



    public void AddItem(Item item)
    {
        unSelecteditems.Add(item);
    }
}
