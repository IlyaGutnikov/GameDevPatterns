using System;

namespace PatternTypeObject
{
    
    /// <summary>
    /// Получает параметры здоровья и атаки из JSON\XML
    /// </summary>
    public class Breed
    {
        private int health;
        private string attack;
        
        public Breed(Breed _parent, int _health, string _attack)
        {
            if (_parent != null)
            {
                if (_health == 0)
                    health = _parent.GetHealth();

                if (String.IsNullOrEmpty(_attack))
                    attack = _parent.GetAttack();
            }
        }

        public int GetHealth()
        {
            return health;
        }

        public string GetAttack()
        {
            return attack;
        }
    }
}