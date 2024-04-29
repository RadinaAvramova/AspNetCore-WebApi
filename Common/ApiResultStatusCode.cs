using System.ComponentModel.DataAnnotations;

namespace Common
{
    public enum ApiResultStatusCode
    {
        [Display(Name = "Operation completed successfully")]
        Success = 0,

        [Display(Name = "A server error occurred")]
        ServerError = 1,

        [Display(Name = "Invalid parameters sent")]
        BadRequest = 2,

        [Display(Name = "Not found")]
        NotFound = 3,

        [Display(Name = "List is empty")]
        ListEmpty = 4,

        [Display(Name = "Processing error occurred")]
        LogicError = 5,

        [Display(Name = "Authentication error")]
        UnAuthorized = 6
    }
}

