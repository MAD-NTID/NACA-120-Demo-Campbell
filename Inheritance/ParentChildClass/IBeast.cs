public interface IBeast
{
    public int CurrentHP { get;}
    public int MaxHp { get; }
    public string Name { get;}
    public string Weakness { get; }
    public IAttack Attack();
    public void TakeDamage(IAttack attack);
}