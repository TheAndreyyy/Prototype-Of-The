using UnityEngine;
using UnityEngine.UI;

public class ButtonsImprovments : MonoBehaviour
{
    [SerializeField]
    private Image image;
    Color32 colorFadein = new Color32(255, 255, 255, 255);
    Color32 colorFadeout = new Color32(255, 255, 255, 0);

    private void OnMouseEnter()
    {
        image.color = colorFadein;
    }

    private void OnMouseExit()
    {
        image.color = colorFadeout;
    }
}
