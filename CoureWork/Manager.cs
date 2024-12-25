using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

public class Manager
{
    private KnapsackStateStorage savedStates;
    private AlgorithmRealization solver;
    public KnapsackStateStorage storage;
    public KnapsackStateStorage GetStorage() { return storage; }

    public void SetSavedState(KnapsackState state)
    {
        solver.SetState(state);
        storage.AddState(state);  // Сохранение состояния в хранилище, если нужно
    }

    public Manager(KnapsackParameters parameters)
    {
        solver = new AlgorithmRealization(parameters.Capacity);
        storage = new KnapsackStateStorage();
        KnapsackState state = solver.SaveKnapsackState();
        storage.AddState(state);
        savedStates = new KnapsackStateStorage();
    }

    public void InitializeKnapsack(int size)
    {
        solver = new AlgorithmRealization(size);
    }

    public KnapsackStateStorage AddItem(string name, int weight, int value)
    {
        Item item = new Item(name, weight, value);
        solver.AddItem(item);
        KnapsackState state = solver.SaveKnapsackState();
        storage.AddState(state);
        return storage;
    }

    public KnapsackStateStorage ResultSolve(int currentStep)
    {
        
        int savedstep = currentStep;
        
        
        KnapsackState savedState = storage._storage[currentStep].Clone();
       
        foreach (var x in storage._storage) 
        { 
            savedStates.AddState(x.Clone());
        }
        List<Item> items = new List<Item>(storage.GetState(currentStep).UnSelectedItems);
        items.Sort((x, y) => (y.Value / y.Weight).CompareTo(x.Value / x.Weight));
        while (storage.GetState(currentStep).SelectedWeight + items[0].Weight 
            <= storage.GetState(currentStep).Capacity)
        {
            
            currentStep++;
            solver.StepSolve();
            KnapsackState state = solver.SaveKnapsackState();
            storage.AddState(state);
            items.RemoveAt(0);
            if (storage.GetState(currentStep).UnSelectedItems.Count == 0)
            {
                break;
            }         
        }

        for (int i = 0; i < savedStates.GetStorageLenght() - 1; i++)
        {
            storage._storage[i] = savedStates._storage[i].Clone();
        }
        storage._storage[savedstep] = savedState; 
        return storage;
    }


    public void SetKnapsackState(KnapsackState state)
    {
        solver.SetState(state);
    }
}
