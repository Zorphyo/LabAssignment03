using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnChangeScript : MonoBehaviour
{
    //variable to get amount needed to make change
    public int amount;

    //variables to hold the number of each type of bill. Variables with "n" in front of them are what is left over for the next bill type.
    int hundred;
    int nhundred;

    int fifty;
    int nfifty;

    int twenty;
    int ntwenty;

    int ten;
    int nten;

    int five;
    int nfive;

    int one;

    // Start is called before the first frame update
    void Start()
    {
        //calculate what bills will be needed for each bill type. Send that amount to the debug log to check for accuracy
        hundred = (amount / 100);
        nhundred = amount % 100;
        Debug.Log(hundred + "\n");

        fifty = (nhundred / 50);
        nfifty = nhundred % 50;
        Debug.Log(fifty + "\n");

        twenty = (nfifty / 20);
        ntwenty= nfifty % 20;
        Debug.Log(twenty + "\n");

        ten = (ntwenty / 10);
        nten = ntwenty % 10;
        Debug.Log(ten + "\n");

        five = (nten / 5);
        nfive = nten % 5;
        Debug.Log(five + "\n");

        one = nfive;
        Debug.Log(one + "\n");

        //at the end of calculating, tell the user how many bills of each type they will get back
        Debug.Log("With " + amount + " dollars, you will get " + hundred + " hundred dollar bill(s), " + fifty + " fifty dollar bill(s), " + twenty + " twenty dollar bill(s), " +
            ten +" ten dollar bill(s), " + five + " five dollar bill(s), and " + one + " one dollar bills.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
