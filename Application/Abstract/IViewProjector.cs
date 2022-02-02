using Domain;

namespace Application.Abstract
{
    /// <summary>
    /// Интерфейс сервиса для выполнения проекций
    /// </summary>
    public interface IViewProjector
    {
        /// <summary>
        /// Провести проекцию вида
        /// </summary>
        /// <param name="cameras">Множество камер для проекции</param>
        /// <param name="model">Модель</param>
        void ProjectView(Camera[] cameras, VisualModel model);
    }
}