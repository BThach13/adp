using System;
using System.ComponentModel;

public class DynamicArray<T>
{
    private T[] array;
    private int count;
    private int capacity;

    public DynamicArray(int initialCapacity = 1) {
        array = new T[initialCapacity];
        count = 0;
        capacity = initialCapacity;
    }

    public void Add(T element) {
        if (count == capacity) {
            Console.WriteLine("Capacity reached while adding element {0}!", element);
            Resize();
        }
        array[count] = element;
        count++;
    }

    public T Get(int index) {
        checkIndex(index);
        return array[index];
    }

    public void Set(int index, T element) {
        checkIndex(index);
        array[index] = element;
    }

    public void RemoveAt(int index) {
        checkIndex(index);
        for (int i = index; i < count - 1; i++) {
            array[i] = array[i + 1];
        }
        count--;
        array[count] = default!;
    }

    public int Size() {
        return count;
    }

    public void Print() {
        for (int i = 0; i < count; i++) {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine();
    }

    private void Resize() {
        capacity = capacity * 2;
        
        T[] newArray = new T[capacity];
        for (int i = 0; i < count; i++)
        {
            newArray[i] = array[i];
        }
        array = newArray;
    }

    private void checkIndex(int index) {
        if (index >= count || index < 0) {
            throw new IndexOutOfRangeException("Index is out of range");
        }
    }
}