
// Create instances of attacks
Attack fireball = new Attack("Fireball", 20);
Attack punch = new Attack("Punch", 10);
Attack kick = new Attack("Kick", 15);

// Create an instance of an enemy
Enemy bandit = new Enemy("Bandit");

// Add attacks to the enemy's AttackList
bandit.AddAttack(fireball);
bandit.AddAttack(punch);
bandit.AddAttack(kick);

// Test the enemy's RandomAttack method
bandit.RandomAttack();
