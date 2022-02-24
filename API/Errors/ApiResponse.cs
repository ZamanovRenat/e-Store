namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "Некорректный запрос клиента.",
                401 => "Для доступа к запрашиваемому ресурсу требуется аутентификация.",
                404 => "Ресурс не был найден.",
                500 => "Внутренняя ошибка сервера.",
                _ => null
            };
        }
    }
} 