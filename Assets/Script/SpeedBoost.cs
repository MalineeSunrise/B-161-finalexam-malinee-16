using UnityEngine;

public class SpeedBoost : Item
{
    public override void ApplyEffect(Player player)
    {
        if (player)
        { 
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
