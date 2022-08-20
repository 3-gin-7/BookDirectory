using Server.Api.Core.Enums;

namespace Server.Api.Core.Response;

public class BaseResponse{
    public string Message { get; protected set; } = string.Empty;
    public string Status => StatusCode.ToString();
    public ResponseStatusEnum StatusCode { get; protected set; }
    public string? ErrorMessage { get; set; } = null;

    public BaseResponse(string message, ResponseStatusEnum statusCode, string? errorMessage = null){
        Message = message;
        StatusCode = statusCode;
        ErrorMessage = errorMessage;
    }
}
