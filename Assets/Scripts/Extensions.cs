using UnityEngine;


public static class Extensions{
    private static LayerMask layerMask = LayerMask.GetMask("Default");
    public static bool Raycast(this Rigidbody2D rb, Vector2 dir)
    {
        if(rb.isKinematic){
            return false;
        }
        float radius = 0.25f;
        float distance = 0.375f;
        RaycastHit2D hit = Physics2D.CircleCast(rb.position,radius,dir,distance, layerMask);
        return hit.collider != null && hit.rigidbody != rb;
    }
}

