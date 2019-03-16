using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(ChestUI))]
public class Chest : MonoBehaviour
{
    [SerializeField]
    private Sprite openedSprite;

    private bool isOpen;

    private SpriteRenderer spriteRenderer;
    private ChestUI chestUI;

    // Start is called before the first frame update
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        chestUI = GetComponent<ChestUI>();
    }

    public void Open()
    {
        isOpen = true;

        if (openedSprite != null)
        {
            spriteRenderer.sprite = openedSprite;
        }

        chestUI.HideText();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isOpen)
        {
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        chestUI.HideText();

        PlayerController playerRef = collision.gameObject.GetComponent<PlayerController>();

        if (playerRef)
        {
            playerRef.currentChestToOpen = null;
        }
    }
}