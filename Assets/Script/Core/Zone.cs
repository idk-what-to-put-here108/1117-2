using UnityEngine;



[RequireComponent(typeof(BoxCollider2D))]
public abstract class Zone : MonoBehaviour
{
    [Header("Zone Settings")]
    [SerializeField] private Color debugColour = new Color(0, 1, 0, 0.3f);

    private void Awake()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }
    //the "contract"
    //every child MUST define what happens in this method

    protected abstract void ApplyZoneEffect(Player player);

    private void OnTriggerStay2D(Collider2D collision)
    {
        // ensure player is in trigger
        if(collision.TryGetComponent(out Player player))
        {
            ApplyZoneEffect(player);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = debugColour;
        BoxCollider2D box = GetComponent<BoxCollider2D>();

        if(box != null)
        {
            Gizmos.DrawCube(transform.position + (Vector3)box.offset, box.size);
        }
    }
}
