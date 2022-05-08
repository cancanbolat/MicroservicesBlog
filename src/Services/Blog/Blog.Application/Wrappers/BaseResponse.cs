namespace Blog.Application.Wrappers
{
    public class BaseResponse<T>
    {
        public string Message { get; set; }
        public bool HasError { get; set; }
        public T Data { get; set; }
    }
}
