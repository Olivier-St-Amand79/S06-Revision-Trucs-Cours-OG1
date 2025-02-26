using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeationBronze : MonoBehaviour
{
    [SerializeField] GameObject _monnaie;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_monnaie, transform.position, transform.rotation); /*transform.position/rotation = prendre la rotation et la position du game object*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
