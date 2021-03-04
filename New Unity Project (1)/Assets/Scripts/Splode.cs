// Grenade explodes after a time delay.
public Splode;

void Start()
{
    {
        Invoke("Explode", fuseTime);
    }



    // Grenade explodes on impact.
    void OnCollisionEnter(Collision coll)
    {
        Explode();
    }
}