﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCharacter : MonoBehaviour
{
    bool mergeConflict;
    // Start is called before the first frame update
    void Start()
    {
        if (mergeConflict)
        {
            ResolveConflicts();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ResolveConflicts()
    {
        //resolve all merge conflicts
    }
}
