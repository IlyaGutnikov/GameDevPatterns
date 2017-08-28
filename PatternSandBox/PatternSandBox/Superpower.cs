namespace PatternSandBox
{
    public class Superpower
    {   
        /// <summary>
        /// Ссылка на стороний код
        /// </summary>
        protected SoundPlayer SoundPlayer;
        
        void Awake()
        {
            SoundPlayer = new SoundPlayer();
        }

        /// <summary>
        /// Метод песочница
        /// </summary>
        protected virtual void Activate()
        {
            
        }
        
        // Предостовляемые операции
        protected void Move()
        {
            
        }
    }
}