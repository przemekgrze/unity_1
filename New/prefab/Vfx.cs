using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vfx : MonoBehaviour
{
    [SerializeField] ParticleSystem[] ps;
    [SerializeField] float _livetimes = 2;
    public void Inits(float time)
    {
        _livetimes = time;
        gameObject.SetActive(true);
        foreach(var j in ps)
        {
            j.Play();
        }
        StartCoroutine(WaitToDisable());
    }
    IEnumerator WaitToDisable()
    {
        yield return new WaitForSeconds(_livetimes);
        DisableObj();
    }
    void DisableObj()
    {
        Destroy(gameObject);
        //GameManager.Instance.AddHealPool(this);
    }
    private void OnDestroy()
    {
        StopAllCoroutines();
    }
    private void OnDisable()
    {
         StopAllCoroutines();
    }
}
