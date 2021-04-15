namespace Oesia.Front.Data.Base
{
    public class ResponseModel<T>
    {
        public string Message { get; set; }
        public bool Response { get; set; }
        public bool ErrorConnection { get; set; }
        public T Result { get; set; }
    }
}
