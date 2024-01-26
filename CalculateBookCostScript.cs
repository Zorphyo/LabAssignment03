using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class CalculateBookCostScript : MonoBehaviour
{  
    //public variables to set the cost of the books and how many copies were sold
    public double bookCost;
    public int bookCopies;

    // Start is called before the first frame update
    void Start()
    {
        //getting the price of the book after the 40% discount
        double price = Math.Round(bookCost * 0.6, 2);
        Debug.Log("The price of the book after discount is $" + price);

        double profit = 0;

        //getting the total profit from selling the books with shipping costs taken out
        if(bookCopies >= 1){

            profit = ((price - 3.0) - ((bookCopies - 1) * 0.75)) * bookCopies;

        }

        Debug.Log("The bookstore made $" + profit + " after shipping costs.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
