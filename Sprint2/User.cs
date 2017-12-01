using System;
using UnityEngine;
using System.Collections;

public class User : MonoBehaviour
{
    private int[] guess;
    private int guessAmount;
    private int maxGuess;

    //get guess
    public System.Int32[] GetGuess() => guess;
    //set guess
    public void SetGuess(System.Int32[] value) => guess = value;

    // Get and set Guess amount
    public System.Int32 GetGuessAmount()
    {
        return maxGguessAmountuess;
    }

    public void SetGuessAmount(System.Int32 value)
    {
        guessAmount = value;
    }


    // Get and set max guess
    public System.Int32 GetMaxGuess()
    {
        return maxGuess;
    }

    public void SetMaxGuess(System.Int32 value)
    {
        maxGuess = value;
    }
}