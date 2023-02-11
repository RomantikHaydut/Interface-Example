
public interface IDamagable<T>
{
    T Health { get; set; }

    void GetDamage(T damageAmount);

    void Die();
}
