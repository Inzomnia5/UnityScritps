using UnityEngine;
using System.Collections;

public class FpsCounter : MonoBehaviour
{
    private float count;

    private IEnumerator Start()
    {
        GUI.depth = 2;
        while (true)
        {
            count = 1f / Time.unscaledDeltaTime;
            yield return new WaitForSeconds(0.1f);
        }
    }

    private void OnGUI()
    {
        Rect location = new Rect(5, 5, 85, 25);
        string text = $"FPS: {Mathf.Round(count)}";
        Texture black = Texture2D.linearGrayTexture;
        GUI.color = Color.black;
        GUI.skin.label.fontSize = 15;
        GUI.Label(location, text);
    }
}