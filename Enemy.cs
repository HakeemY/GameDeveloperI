public class Enemy
{
    // Fields
    public string Name { get; }
    private int Health { get; set; }
    private List<Attack> AttackList { get; }

    // Constructor
    public Enemy(string name)
    {
        Name = name;
        Health = 100; // Default health
        AttackList = new List<Attack>();
    }

    // Method to add an attack to the enemy's AttackList
    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    // Method for the enemy to perform a randomized attack
    public void RandomAttack()
    {
        Random random = new Random();
        if (AttackList.Count > 0)
        {
            int randomIndex = random.Next(AttackList.Count);
            Attack attack = AttackList[randomIndex];
            Console.WriteLine($"{Name} performs {attack.Name} and deals {attack.DamageAmount} damage!");
        }
        else
        {
            Console.WriteLine($"{Name} has no attacks!");
        }
    }
}
