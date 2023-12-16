namespace Core.Models;
/// <summary>
/// Task for string
/// </summary>
public class MyClass
{
    private string[] _arr;
    public MyClass()
    {
        _arr = new string[0];
    }
    public void Add(string obj)
    {
        Array.Resize(ref _arr, _arr.Length+1);
        _arr[^1] = obj;
    }
    public void ShowAll()
    {
        foreach (string item in _arr) 
        {
            Console.WriteLine(item);
        }
    }
    public int FindIndexOf(string obj)
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            if (_arr[i] == obj)
            {
                return i;
            }
        }
        return - 1;
    }
    
    public void Remove(string obj)
    {
        int findIndex = FindIndexOf(obj);   //1
        if (findIndex is not -1)
        {
            for (int i = findIndex + 1; i < _arr.Length; i++)   //i=2 //i=3
            {
                _arr[i - 1] = _arr[i];     //Pizza =>2  // Pizza =>3
            }
            Array.Resize(ref _arr, _arr.Length - 1);
        }
        else Console.WriteLine("This object does not exist in the current array.");
    }
}
