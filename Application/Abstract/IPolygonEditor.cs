using Domain;

namespace Application.Abstract
{
    /// <summary>
    /// Интерфейс сервиса по работе с полигонами в визуальной модели
    /// </summary>
    public interface IPolygonEditor
    {
        /// <summary>
        /// Добавление полигона в модель
        /// </summary>
        /// <param name="m">Модель, в которую добавляется полигон</param>
        /// <param name="p">Добавляемый полигон</param>
        /// <returns></returns>
        VisualModel AddPolygon(VisualModel m, Polygon p);

        /// <summary>
        /// Удаление полигона из модели
        /// </summary>
        /// <param name="m">Модель, из которой необходимо удалить полигон</param>
        /// <param name="p">Удаляемый полигон</param>
        /// <returns></returns>
        VisualModel RemovePolygon(VisualModel m, Polygon p);

        /// <summary>
        /// Метод редактирования полигона
        /// </summary>
        /// <param name="newPolygon">Полигон, содержащий новые свойства</param>
        /// <param name="oldPolygon">Редактируемый полигон</param>
        /// <returns></returns>
        Polygon EditPolygon(Polygon newPolygon, Polygon oldPolygon);
    }
}