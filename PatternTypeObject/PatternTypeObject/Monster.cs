namespace PatternTypeObject
{
    public class Monster
    {
        private Breed breed;

        private int health;
        
        /// <summary>
        /// Создается на основе данных
        /// </summary>
        /// <param name="_breed"></param>
        public Monster(Breed _breed)
        {
            breed = _breed;
            health = _breed.GetHealth();
        }

        public string GetAttack()
        {
            return breed.GetAttack();
        }
        
    }
}