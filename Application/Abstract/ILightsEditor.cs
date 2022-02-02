using Domain;

namespace Application.Abstract
{
    /// <summary>
    /// Интерфейс сервиса по работе с источниками света
    /// </summary>
    public interface ILightsEditor
    {
        /// <summary>
        /// Добавление источника света в сцену
        /// </summary>
        /// <param name="s">Сцена, в которую добавляется источник света</param>
        /// <param name="l">Добавляемый источник света</param>
        /// <returns></returns>
        Scene Add(Scene s, LightSource l);
        
        /// <summary>
        /// Удаление источника света из сцена
        /// </summary>
        /// <param name="s">Сцена, из которой нужно удалить источник света</param>
        /// <param name="l">Удаляемый источник света</param>
        /// <returns></returns>
        Scene Remove(Scene s, LightSource l);

        /// <summary>
        /// Редактирование температуры освещения у источника света
        /// </summary>
        /// <param name="l">Редактируемый источник света</param>
        /// <param name="temp">Новая температура света в Кельвинах</param>
        /// <returns></returns>
        LightSource EditLightTemperature(LightSource l, int temp);

        //...
        //другие методы по редактированию свойств источника света
    }
}