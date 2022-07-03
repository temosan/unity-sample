using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public GameObject buttonPrefeb;

    // Start is called before the first frame update
    void Start()
    {
        GridLayoutGroup group = this.GetComponent<GridLayoutGroup>();

        int itemCount = 30;
        for (int i = 0; i < itemCount; i++) {
            GameObject newObject = Instantiate(buttonPrefeb, group.transform);

            ButtonPanel buttonPanel = newObject.GetComponent<ButtonPanel>();
            buttonPanel.addEvent(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buttonTapped()
    {

    }
}
