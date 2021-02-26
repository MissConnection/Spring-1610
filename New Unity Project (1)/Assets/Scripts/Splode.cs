// Grenade explodes after a time delay.
public float Splode;

void Start()
{
    {
        Invoke("Explode", Splode);
    }



    // Grenade explodes on impact.
    void OnCollisionEnter(Collision coll)
    {
        Explode(ball);
    }
}