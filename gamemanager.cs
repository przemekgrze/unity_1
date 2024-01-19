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

        CastText.text = "Cash" + Cash;

        Debug.Log(Cash);
        Debug.Log(Life);
        Debug.Log(Mood);
        Debug.Log(PracaFizyczna);
        Debug.Log(Body);

        // Tworzymy instancjê skryptu Zarobek i przypisujemy do zmiennej zarobekScript
        zarobekScript = gameObject.AddComponent<Cash0408>();
        zarobekScript = GetComponent<Cash0408>();

        // Inicjalizacja gry
        InitializeGame();
    }

    private void InitializeGame()
    {
        // Mo¿esz tutaj dodaæ dowoln¹ logikê inicjalizacji gry, jeœli jest potrzebna
        // Na przyk³ad, ustawienie pocz¹tkowych wartoœci dla zmiennych w skrypcie Zarobek.
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
