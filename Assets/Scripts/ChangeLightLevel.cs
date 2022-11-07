using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ChangeLightLevel : MonoBehaviour
{
    public List<Light> Lights;
    // create lightframe and lightbutton vars
    private VisualElement lightFrame;
    private Button lightButton;

    private void OnEnable()
    {
        // get the UIDocument component
        var uiDocument = GetComponent<UIDocument>();

        // get the rootVisualElement (the frame component)
        var rootVisualElement = uiDocument.rootVisualElement;
        lightFrame = rootVisualElement.Q<VisualElement>("LightFrame");

        // get the button which is nested in the frame
        lightButton = lightFrame.Q<Button>("LightButton");

        // create event listener that calls ChangeLight() when pressed
        lightButton.RegisterCallback<ClickEvent>(ev => ChangeLight());
    }

    // init click counter
    int click = 0;

    private void ChangeLight()
    {
        if(click == 0)
        {
            Lights.ForEach(light => light.intensity = 1);
        }
        if (click == 1)
        {
            Lights.ForEach(light => light.intensity = 0.5f);
        }
        if (click == 2)
        {
            Lights.ForEach(light => light.intensity = 0);
        }
        click++;

        // reset counter (3 light levels)
        if (click > 2)
        {
            click = 0;
        }
    }
}
