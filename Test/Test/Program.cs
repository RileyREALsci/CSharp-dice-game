// See https://aka.ms/new-console-template for more information

Random random = new Random();
int player = 10;
int enemy = 10;
int playerAttack;
int enemyAttack;

int enemiesKilled = 0;

Console.WriteLine($"Player health: {player}\tEnemy health: {enemy}\n\n");

while (player > 0 & enemy > 0)
{

    playerAttack = random.Next(1,11);
    enemyAttack = random.Next(1,11);    
    

    if (playerAttack > enemyAttack)
    {
        enemy -= playerAttack;

        Console.WriteLine($"\nEnemy attack {enemyAttack}\nPlayer attack {playerAttack}\nPLAYER HITS!\n\nPlayer health: {player}\tEnemy health: {enemy}");
    }
    else
    {
        player -= enemyAttack;

        Console.WriteLine($"\nEnemy attack {enemyAttack}\nPlayer attack {playerAttack}\nENEMY HITS!\n\nPlayer health: {player}\tEnemy health: {enemy}");
    }
}

if  (player > enemy)
{
    enemiesKilled++;
    enemy = 10;
    Console.WriteLine("Player killed: " + enemiesKilled);
}
else
{
    Console.WriteLine("Enemy Wins!\tPlayer killed: " + enemiesKilled + "'s");
}