using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    private bool isFirstUpdate = true;

    private void Update() {
        if (isFirstUpdate) {
            isFirstUpdate = false;

            Loader.LoaderCallback();
        }
    }
}
