using Microsoft.AspNetCore.Components.Web;

namespace Mango.Web.Models
{
    public class ResponseDto
    {

        public object? Result { get; set; }
        public bool IsSuccess { get; set; }=true;
        public string? Message { get; set; } = "";
    }
}
