namespace PatternPrototype
{
    public class Spawner
    {
        private Monster _prototype;

        public Spawner(Monster prototype)
        {
            _prototype = prototype;
        }

        public Monster SpawnMonster()
        {
            return _prototype.clone();
        }
    }
}