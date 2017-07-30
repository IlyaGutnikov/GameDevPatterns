namespace PatternPrototype
{
    public class Ghost : Monster
    {

        private int _health;
        private int _armor;

        public Ghost(int health, int armor)
        {
            _health = health;
            _armor = armor;
        }

        public override Monster clone(int health, int armor)
        {
            return new Ghost(health, armor);
        }
    }
}