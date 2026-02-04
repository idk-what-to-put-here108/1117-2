using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float patrolDistance = 5f;
    private Vector2 startPos;
    private int direction = -1;

    protected override void Awake()
    {
        base.Awake();
        startPos = transform.position;
    }

    private void Update()
    {
        float leftBoundary = startPos.x - patrolDistance; //starting pos - patroldistance
        float rightBoundary = startPos.x + patrolDistance;
        transform.Translate(Vector2.right * direction * MoveSpeed * Time.deltaTime);

        if(transform. position.x >= rightBoundary)
        {
            direction = -1;
            transform.localScale = new Vector3(1,1,1);
        }
        else if (transform.position.x <= leftBoundary)
        {
            direction = 1;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }

    public override void Die()
    {
        Debug.Log("Enemy has died");
        //allows for more custimization and more specific things to happen per character
    }
}
