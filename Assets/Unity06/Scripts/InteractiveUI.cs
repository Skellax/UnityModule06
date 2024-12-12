using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveUI : MonoBehaviour
{
    [SerializeField] private CanvasGroup UI;
    [SerializeField] private TMP_Text interactiveText;

    // Start is called before the first frame update
    void Start()
    {
        UI.enabled = false;
    }

    public void SwitchActiveUI(bool reponse) {
        UI.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
