namespace Domain
{
    /// <summary>
    /// Интерфейс репозитория сцен. Реализации могут отличаться (например, чтение с диска или чтение по сети)
    /// </summary>
    public interface ISceneRepository
    {
        public Scene Get(string path);
    }
}