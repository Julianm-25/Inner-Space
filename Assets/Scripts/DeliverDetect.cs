using UnityEngine;

/// <summary>
/// Used to detect whether the box has been delivered, and trigger the win screen when it is
/// </summary>
public class DeliverDetect : MonoBehaviour
{
    /// <summary>
    /// The object this script is attached to
    /// </summary>
    public GameObject guard;
    /// <summary>
    /// The player character
    /// </summary>
    public GameObject player;
    /// <summary>
    /// The win screen
    /// </summary>
    public GameObject winCanvas;
    // Update is called once per frame
    private void Update()
    {
        var detect = guard.transform.position;
        RaycastHit hit;
        if (Physics.Raycast(detect, guard.transform.forward, out hit, 10))
            if (hit.collider.CompareTag("Interactable"))
            {
                winCanvas.SetActive(true);
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
    }
}