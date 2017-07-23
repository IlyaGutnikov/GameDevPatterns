using System;

namespace PatternObserver.Interfaces
{
    /// <summary>
    /// Наблюдатель
    /// </summary>
    public interface IObserver
    {    
        /// <summary>
        /// Обновление информации для наблюдателя
        /// </summary>
        /// <param name="ob">Пересылка информации</param>
        void Update(Object ob);
    }
}