using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayListManager : MonoBehaviour
{
    // Use a List to hold items
    [SerializeField] public List<string> itemList = new List<string>();

    // Function to add an item to the ArrayList
    public void AddItem(string item)
    {
        itemList.Add(item);
        Debug.Log($"Added: {item}");
    }

    // Function to delete an item from the ArrayList
    public void DeleteItem(string item)
    {
        if (itemList.Contains(item))
        {
            itemList.Remove(item);
            Debug.Log($"Deleted: {item}");
        }
        else
        {
            Debug.Log($"Item not found: {item}");
        }
    }

    // Function to display all items in the ArrayList
    public void DisplayItems()
    {
        Debug.Log("Current items in the list:");
        foreach (string item in itemList)
        {
            Debug.Log(item);
        }
    }

    // Example of adding and deleting items
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (itemList.Count > 0)
            {
                string itemToDelete = (string)itemList[0]; // Deletes the first item in the list
                DeleteItem(itemToDelete);
                DisplayItems();
            }
        }
    }
}
