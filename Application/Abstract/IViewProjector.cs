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
        /// <param name="camera">Камера, с которой проводится проекция</param>
        /// <param name="model">Модель</param>
        void ProjectView(Camera camera, VisualModel model);
    }
}