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

    // Dodaj now� publiczn� flag�, kt�ra b�dzie informowa� o rozpocz�ciu zarabiania.
    public bool StartEarning { get; private set; }

    // Funkcja g��wna
    public void StartMe()
    {
        zarobekScript.StartMe();
        int cashValue = zarobekScript.Cash;
        onZarobekStart.Invoke();


        // p�tla niesko�czona, w kt�rej gracz mo�e wykonywa� r�ne akcje, a� do momentu wyj�cia z gry
        while (true)
        {
            Console.WriteLine("Co chcesz zrobi�?");
            Console.WriteLine("1. Praca fizyczna");
            Console.WriteLine("2. Wyjazd do Dubaju");
            Console.WriteLine("3. Fa�szowanie faktur");
            Console.WriteLine("4. Sp�ka na Malcie/Cyprze");

            int opcja = Convert.ToInt32(Console.ReadLine());

            switch (opcja)
            {
                case 1:
                    // zarobek poprzez prac� fizyczn�
                    if (PracaFizyczna)
                    {
                        Cash += 10; // dodanie 10 z� do konta
                        Debug.Log("Zarobi�e� 10 z� z tytu�u pracy fizycznej.");
                        Debug.Log("Tw�j stan konta: " + Cash + " z�");
                    }
                    else
                    {
                        Debug.Log("Nie masz dost�pu do tej funkcjonalno�ci.");
                    }
                    break;

                case 2:
                    // zarobek poprzez wyjazd do Dubaju
                    if (WyjazdDubai && (Aktywnosc >= 50 || Life >= 50))
                    {
                        Cash += 1000; // dodanie 1000 z� do konta
                        Debug.Log("Zarobi�e� 1000 z� z tytu�u wyjazdu do Dubaju.");
                        Debug.Log("Tw�j stan konta: " + Cash + " z�");
                    }
                    else
                    {
                        Debug.Log("Nie masz dost�pu do tej funkcjonalno�ci lub nie spe�niasz wymaga�.");
                    }
                    break;

                case 3:
                    // zarobek poprzez fa�szowanie faktur
                    if (FalszowanieFaktur && (Aktywnosc >= 30 || Life >= 30 || Body >= 30))
                    {
                        Cash += 500;
                        Debug.Log("Zarobi�e� 500 z� z tytu�u fa�szowania faktur.");
                        Debug.Log("Tw�j stan konta: " + Cash + " z�");
                    }
                    else
                    {
                        Debug.Log("Nie masz dost�pu do tej funkcjonalno�ci.");
                    }
                    break;

                case 4:
                    if (SpolkaMaltaCypr && (Aktywnosc >= 30 || Life >= 30 || Body >= 30))
                    {
                        Cash += 5000; // dodanie 5000 z� do konta
                        Debug.Log("Zarobi�e� 5000 z� z tytu�u sp�ki na Malcie/Cyprze.");
                        Debug.Log("Tw�j stan konta: " + Cash + " z�");
                    }
                    else
                    {
                        Debug.Log("Nie masz dost�pu do tej funkcjonalno�ci.");
                    }
                    break;

                default:
                    Debug.Log("Niepoprawna opcja. Spr�buj ponownie.");
                    break;
            }
        }
    }
}
