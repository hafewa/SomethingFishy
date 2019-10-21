﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceSetter : MonoBehaviour
{
    public SharedGameObject gameObjectReference;

    void Awake()
    {
        gameObjectReference.Value = gameObject;
    }
}
