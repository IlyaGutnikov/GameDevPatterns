namespace PatternState
{
    /// <summary>
    /// Базовый класс для состояний героини
    /// </summary>
    public class HeroineState
    {
        /// <summary>
        /// Обрабатываем ввод
        /// </summary>
        /// <param name="heroine"></param>
        /// <param name="input"></param>
        public virtual HeroineState HandleInput(Heroine heroine, Input input)
        {
            return null;
        }
        
        public virtual void Update(Heroine heroine)
        {
            
        }
        
        /// <summary>
        /// Входное состояние
        /// </summary>
        /// <param name="heroine"></param>
        public virtual void EnterAction(Heroine heroine)
        {
            
        }

        public virtual void ExitAction(Heroine heroine)
        {
            
        }
    }
}