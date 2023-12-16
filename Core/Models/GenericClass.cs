using System.Threading.Channels;

namespace Core.Models;
/// <summary>
/// Task for generic type
/// </summary>
public class GenericClass<T>
{
    private T[] _arr;
    public GenericClass()
    {
        _arr = new T[0];
    }
    public void Add(T obj)
    {
        Array.Resize(ref _arr, _arr.Length+1);
        _arr[^1] = obj;
    }
    public void ShowAll()
    {
        foreach (T obj in _arr) 
        {
            Console.WriteLine(obj);
        }
    }
    public int FindIndexOf (T obj)
    {
        for (int i=0; i< _arr.Length; i++) 
        {
            if (Equals(_arr[i], obj)) return i;            
        } 
        return -1;
    }
    public void Remove(T obj) 
    {
        int removeIndex = FindIndexOf(obj);
        if (removeIndex is not -1)
        {
            for (int i = removeIndex + 1; i < _arr.Length; i++)
            {
                _arr[i - 1] = _arr[i];
            }
            Array.Resize(ref _arr, _arr.Length - 1);
        }
        else Console.WriteLine("Object does not exist in the current array.");
    }
}
