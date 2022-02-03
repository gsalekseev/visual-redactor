using Domain;

namespace Application.Abstract
{
    /// <summary>
    /// Интерфейс преобразования байтового массива из файла в объекты сцены.
    /// Может быть реализован с помощью различных алгоритмов
    /// </summary>
    public interface ISceneObjectsFormatter
    {
        /// <summary>
        /// Преобразования байтового массива из файла в объекты сцены
        /// </summary>
        /// <param name="bytes">Массив байтов</param>
        /// <returns>Сцена с объектами</returns>
        public Scene Format(byte[] bytes);
    }
}