public interface IBeast
{
    public int CurrentHP { get;}
    public int MaxHp { get; }
    public string Name { get;}
    public string Weakness { get; }
    public Attack Attack();
    public void TakeDamage(Attack attack);
}