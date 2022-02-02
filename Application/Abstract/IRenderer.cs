using System.Drawing;

namespace Application.Abstract
{
    /// <summary>
    /// Интерфейс сервиса рендеринга объекта
    /// </summary>
    public interface IRenderer<TRendered>
    {
        /// <summary>
        /// Метод рендеринга объекта 
        /// </summary>
        /// <param name="toRender">Тип объекта для рендеринга</param>
        Bitmap Render(TRendered toRender);
    }
}