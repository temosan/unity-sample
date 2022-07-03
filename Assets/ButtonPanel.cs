using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour
{
    public Image image;
    public Button button;
    int index = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        image = transform.GetComponentInChildren(typeof(Image)) as Image;
        button = transform.GetComponentInChildren(typeof(Button)) as Button;
    }

    void Start()
    {
        

        //RectTransform sizeTransForm = GetComponent<RectTransform>();
    }

    public void addEvent(int i)
    {
        this.index = i;
        button.onClick.AddListener(() =>
        {
            Debug.Log(this.index);
        });
    }

    public void addEvent(UnityEngine.Events.UnityAction call) {
        button.onClick.AddListener(call);
    }
}
