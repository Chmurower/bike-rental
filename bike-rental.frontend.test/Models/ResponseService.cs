    namespace bike_rental.frontend.test.Models
    {
        public class ResponseService <T>
        {
            public bool IsSucess { get; set; }
            public string Message { get; set; }
            public DateTime Time { get; set; }
            public T Data { get; set; }
        }
    }