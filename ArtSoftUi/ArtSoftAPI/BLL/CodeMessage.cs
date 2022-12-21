using ArtSoftAPI.ProxyClases;

namespace ArtSoftAPI.BLL
{
    /// <summary>
    /// Клас для кодів відповіді
    /// </summary>
    public class CodeMessage
    {
        /// <summary>Успішна обробка</summary>
        public static ResponseBody SW_0001 => new ResponseBody { Code = "0001", Type = "SUCCESS", Message = "Повідомлення успішно оброблено" };
        /// <summary>Системна помилка при обробці повідомлення</summary>
        public static ResponseBody SW_0002 => new ResponseBody { Code = "0002", Type = "ERROR", Message = "Системна помилка при обробці повідомлення" };
        /// <summary>Перевищено час очікування при обробці повідомлення</summary>
        public static ResponseBody SW_0003 => new ResponseBody() { Code = "0003", Type = "TIMEOUT", Message = "Перевищено час очікування при обробці повідомлення" };
    }
}
