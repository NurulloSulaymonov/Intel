namespace Domains.Models
{
    public class GenericResponse<T>  where T: class
    {
        public T Response { get; set; }
        

        public GenericResponse(T response)
        {
           Response = response;
        }
    }
}