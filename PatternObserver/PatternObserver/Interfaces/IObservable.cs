namespace PatternObserver.Interfaces
{
    /// <summary>
    /// Наблюдаемый объект
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Добавление наблюдателя
        /// </summary>
        /// <param name="o">Наблюдатель, который реализует <see cref="IObserver"/></param>
        void AddObserver(IObserver o);
        
        /// <summary>
        /// Удаление наблюдателя
        /// </summary>
        /// <param name="o">Наблюдатель, который реализует <see cref="IObserver"/></param>
        void RemoveObserver(IObserver o);
        
        /// <summary>
        /// Оповещение наблюдателей
        /// </summary>
        void NotifyObservers();
    }
}