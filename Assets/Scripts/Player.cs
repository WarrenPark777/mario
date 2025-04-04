using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRenderer smallRenderer;
    public PlayerSpriteRenderer bigRenderer;
    private DeathAnimation deathAnimation;
    private AnimatedSprite animatedSprite;
    public bool small=>smallRenderer.enabled;
    public bool dead => deathAnimation.enabled;
    private void Awake(){
        deathAnimation = GetComponent<DeathAnimation>();
        animatedSprite = GetComponentInChildren<AnimatedSprite>();

    }
    public void Hit(){
        if(!small){
            Shrink();
        }
        else{
            Death();
        }
    }
    private void Shrink(){
        //todo
    }
    private void Death(){
        smallRenderer.enabled = false;
        bigRenderer.enabled = false;
        deathAnimation.enabled = true;
        animatedSprite.enabled = false;
        GameManager.Instance.ResetLevel(3f);
        
    }
}
