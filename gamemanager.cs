using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public Cash0408 cashScript;
    private Cash0408 zarobekScript;
    int Cash;
    int Life;
    int PracaFizyczna;
    int Body;
    public UnityEvent onGameManagerStart;

    private void Start()
    {

        // Tworzymy instancj� skryptu Zarobek i przypisujemy do zmiennej zarobekScript
        zarobekScript = gameObject.AddComponent<Cash0408>();
        zarobekScript = GetComponent<Cash0408>();

        // Inicjalizacja gry
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Mo�esz tutaj doda� dowoln� logik� inicjalizacji gry, je�li jest potrzebna
        // Na przyk�ad, ustawienie pocz�tkowych warto�ci dla zmiennych w skrypcie Zarobek.
        zarobekScript.Cash = 0;
        zarobekScript.Life = 100;
        zarobekScript.Body = 100;
        zarobekScript.Aktywnosc = 100;

        Debug.Log($"Initialize:<color=yellow>{zarobekScript.Cash}</color>");
        Debug.Log($"Initialize:<color=yellow>{zarobekScript.Life}</color>");

        // Uruchomienie metody StartMe() w skrypcie Zarobek
        zarobekScript.StartMe();

        onGameManagerStart.Invoke();

    }
}

