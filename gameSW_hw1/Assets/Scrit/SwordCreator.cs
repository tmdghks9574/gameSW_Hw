using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCreator : MonoBehaviour
{
    public GameObject sword;

    public float startTime = 1f;

    public float repeatRate = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("createSword", startTime, repeatRate);
    }

    private void createSword()
    {
        var randomX = Random.Range(-8.5f, 8.5f);
        var randomPosition = new Vector3(randomX, 5f, 0f);

        GameObject cloneSword = Instantiate(sword);
        cloneSword.transform.position = randomPosition;
        cloneSword.gameObject.SetActive(true);
    }
}
