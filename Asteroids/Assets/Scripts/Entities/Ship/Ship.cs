using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : CommonBehaviours
{
    [SerializeField] ShipProbs_SO ShipProbs;
    [SerializeField] Bullet BulletPrefab;
    private Rigidbody2D MyRB;
    private static GameObject MyShip;
    private static int MyLives;
    public override Rigidbody2D spawn(Vector2 position, Transform parent = null)
    {
        MyRB = base.spawn(position, parent);
        MyShip = MyRB.gameObject;
        MyLives = ShipProbs.NumberOfLives;
        return MyRB;
    }
    private void Update()
    {
        EdgeCrossBehaviour();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void LoseLife()
    {
        MyLives--;
        if(MyLives > 0)
        {
            EventManager.Instance.ShipDie.Invoke();
            Time.timeScale = 0;
            //Update UI
            //All bullets and asteroids disappear
            //Restart Game after 2 seconds
            Destroy(MyShip);
        }
        else if(MyLives == 0)
        {
            //Show restart UI
        }
    }

    protected new void OnTriggerEnter2D(Collider2D collision)
    {
        LoseLife();

        if (!collision.gameObject.GetComponent<Asteroid>())
        {
            base.OnTriggerEnter2D(collision);
        }
    }
    public void Move()
    {
        if(MyRB != null)
        {
            float VerticalValue = Input.GetAxis("Vertical");
            float HorizontalValue = Input.GetAxis("Horizontal");
            MyRB.velocity = MyShip.transform.up * VerticalValue * ShipProbs.Speed * Time.deltaTime + MyShip.transform.right * HorizontalValue * (ShipProbs.Speed / ShipProbs.SteeringRotation) * Time.deltaTime;
            MyShip.transform.Rotate(this.transform.forward, -HorizontalValue * ShipProbs.SteeringRotation);
        }
    }
    public void Shoot()
    {
        BulletPrefab.spawn(this.transform.position + this.transform.up * 1.1f, this.transform.rotation);
    }
    protected override void CollideWithBullet()
    {
        LoseLife();
    }
}
