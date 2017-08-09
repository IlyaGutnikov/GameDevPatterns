namespace PatternState
{
    /// <summary>
    /// Класс героини
    /// </summary>
    public class Heroine
    {
        private HeroineState _state;
        
        public virtual void HandleInput(Input input)
        {
            // Создаем объект состояния когда в него переходим 
            HeroineState newState = _state.HandleInput(this, input);

            if (newState != null)
            {
                // Выходное действие от старого состояния
                _state.ExitAction(this);
                
                // Освобождаем память
                _state = null;
                // Добавляем новое состояние
                _state = newState;

                // Входное действие при новом состоянии
                _state.EnterAction(this);
            }
        }

        public virtual void Update()
        {
            _state.Update(this);
        }
    }
}