using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Breakable : MonoBehaviour
{
    public List<GameObject> breakablePieces;
    public float timeToBreak = 2f;
    private float timer = 0f;
    public UnityEvent Onbreak;
    void Start()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
    }

    public void Break()
    {
        timer += Time.deltaTime;
        if (timer > timeToBreak)
        {
            foreach (var item in breakablePieces)
            {
                item.SetActive(true);
                item.transform.parent = null;
            }

            Onbreak.Invoke();
            gameObject.SetActive(false);
        }
    }
}
