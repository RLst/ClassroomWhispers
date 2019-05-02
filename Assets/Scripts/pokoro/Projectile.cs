using UnityEngine;

public class Player : MonoBehaviour { }
public class Enemy : MonoBehaviour { }

public class Projectile : MonoBehaviour
{
    [SerializeField] GameObject projectileParticle;
    [SerializeField] GameObject hitParticle;

    [SerializeField] Player player;
    [SerializeField] Enemy enemy;
    private float explosionForce;

    void Start()
    {
        //Cache references to your player
        player = GetComponent<Player>();
    }

    void Update()
    {
        //Shoot when key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Calculate move vector
            var particleDirection = Vector3.Normalize(enemy.transform.position - player.transform.position);

            //Instantiate particle at player's position and orientation
            var newProjectile = Instantiate(projectileParticle, player.transform.position, player.transform.rotation);

            //Start moving particle (physics or manually)
            newProjectile.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, player.transform.position, 1, 1, ForceMode.Impulse);
        }
    }


    void OnCollisionEnter(Collision collision)
    {
        //Check you hit the correct object/enemy
        if (collision.gameObject.GetComponent<Enemy>() != null) //If the game object that has been hit has a enemy component ie. is an enemy
        {
            //Instantiate a hit particle
            var newHitParticle = Instantiate(hitParticle, collision.contacts[0].point, Quaternion.identity);

            //Delete particle after one second
            Destroy(newHitParticle, 1f);
        }
    }

}
