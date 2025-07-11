namespace MyApp.Application.DTOs
{
    public class WithdrawMoneyResponse
    {
        public bool Success { get; }
        public string Message { get; }

        public WithdrawMoneyResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
