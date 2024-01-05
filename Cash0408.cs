using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;


public class Zarobek : MonoBehaviour
{
    public int Cash;
    public int Life;
    public int Body;
    public int Aktywnosc;
    public Zarobek zarobekScript;
    public UnityEvent onZarobekStart;


    bool PracaFizyczna = true;
    bool WyjazdDubai = true;
    bool FalszowanieFaktur = true;
    bool SpolkaMaltaCypr = true;

    // Dodaj now¹ publiczn¹ flagê, która bêdzie informowaæ o rozpoczêciu zarabiania.
    public bool StartEarning { get; private set; }

    // Funkcja g³ówna
    public void StartMe()
    {
        zarobekScript.StartMe();
        int cashValue = zarobekScript.Cash;
        onZarobekStart.Invoke();


        // pêtla nieskoñczona, w której gracz mo¿e wykonywaæ ró¿ne akcje, a¿ do momentu wyjœcia z gry
        while (true)
        {
            Console.WriteLine("Co chcesz zrobiæ?");
            Console.WriteLine("1. Praca fizyczna");
            Console.WriteLine("2. Wyjazd do Dubaju");
            Console.WriteLine("3. Fa³szowanie faktur");
            Console.WriteLine("4. Spó³ka na Malcie/Cyprze");

            int opcja = Convert.ToInt32(Console.ReadLine());

            switch (opcja)
            {
                case 1:
                    // zarobek poprzez pracê fizyczn¹
                    if (PracaFizyczna)
                    {
                        Cash += 10; // dodanie 10 z³ do konta
                        Debug.Log("Zarobi³eœ 10 z³ z tytu³u pracy fizycznej.");
                        Debug.Log("Twój stan konta: " + Cash + " z³");
                    }
                    else
                    {
                        Debug.Log("Nie masz dostêpu do tej funkcjonalnoœci.");
                    }
                    break;

                case 2:
                    // zarobek poprzez wyjazd do Dubaju
                    if (WyjazdDubai && (Aktywnosc >= 50 || Life >= 50))
                    {
                        Cash += 1000; // dodanie 1000 z³ do konta
                        Debug.Log("Zarobi³eœ 1000 z³ z tytu³u wyjazdu do Dubaju.");
                        Debug.Log("Twój stan konta: " + Cash + " z³");
                    }
                    else
                    {
                        Debug.Log("Nie masz dostêpu do tej funkcjonalnoœci lub nie spe³niasz wymagañ.");
                    }
                    break;

                case 3:
                    // zarobek poprzez fa³szowanie faktur
                    if (FalszowanieFaktur && (Aktywnosc >= 30 || Life >= 30 || Body >= 30))
                    {
                        Cash += 500;
                        Debug.Log("Zarobi³eœ 500 z³ z tytu³u fa³szowania faktur.");
                        Debug.Log("Twój stan konta: " + Cash + " z³");
                    }
                    else
                    {
                        Debug.Log("Nie masz dostêpu do tej funkcjonalnoœci.");
                    }
                    break;

                case 4:
                    if (SpolkaMaltaCypr && (Aktywnosc >= 30 || Life >= 30 || Body >= 30))
                    {
                        Cash += 5000; // dodanie 5000 z³ do konta
                        Debug.Log("Zarobi³eœ 5000 z³ z tytu³u spó³ki na Malcie/Cyprze.");
                        Debug.Log("Twój stan konta: " + Cash + " z³");
                    }
                    else
                    {
                        Debug.Log("Nie masz dostêpu do tej funkcjonalnoœci.");
                    }
                    break;

                default:
                    Debug.Log("Niepoprawna opcja. Spróbuj ponownie.");
                    break;
            }
        }
    }
}
