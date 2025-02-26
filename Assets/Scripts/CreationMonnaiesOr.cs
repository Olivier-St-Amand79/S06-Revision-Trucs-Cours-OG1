using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesOr : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f); /*Quaternion = rotation à l'espace 3d*/
        Instantiate(_prefabOriginal, _positionCreation, _rotation); /*Instantiate = creation de prefab (comme clone)*/
    }
}
