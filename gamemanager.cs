using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public Cash0408 cashScript;
    private Cash0408 zarobekScript;
    int Cash;
    int Life;
    int PracaFizyczna;
    int Body;
    int Mood;
    public UnityEvent onGameManagerStart;
    public Text CastText;

    private void Start()
    {
        Cash = 10;
        Life = 0;
        Body = 0;
        Mood = 100;

        zarobekScript = cashScript;

        // Upewnij si�, �e zarobekScript nie jest null przed u�yciem
        if (zarobekScript != null)
        {
            zarobekScript.Cash = 0;
            zarobekScript.Life = 100;
            zarobekScript.Body = 100;
            zarobekScript.Aktywnosc = 100;



            Debug.Log($"Initialize:<color=yellow>{zarobekScript.Cash}</color>");
            Debug.Log($"Initialize:<color=yellow>{zarobekScript.Life}</color>");

            // Uruchomienie metody StartMe() w skrypcie Zarobek
            zarobekScript.StartMe();
        }
        else
        {
            Debug.LogError("ZarobekScript nie zosta� znaleziony!");
        }

        Debug.Log(Cash);
        Debug.Log(Life);
        Debug.Log(Mood);
        Debug.Log(PracaFizyczna);
        Debug.Log(Body);

        // Inicjalizacja gry
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Mo�esz tutaj doda� dowoln� logik� inicjalizacji gry, je�li jest potrzebna
        // Na przyk�ad, ustawienie pocz�tkowych warto�ci dla zmiennych w skrypcie Zarobek.

        // Uruchomienie metody StartMe() w skrypcie Zarobek
        if (zarobekScript != null)
        {
            zarobekScript.StartMe();
        }

        // Wywo�anie zdarzenia onGameManagerStart
        onGameManagerStart.Invoke();
    }
}
