namespace EscolaOnline.Api.ViewModels
{
    public class ResultViewModel<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; } = new();

        //To Get the data and see the errors
        public ResultViewModel(T data, List<string> errors)
        {
            Data = data;
            Errors = errors;
        }

        //To Get the data
        public ResultViewModel(T data)
        {
            Data = data;
        }

        //To See the errors
        public ResultViewModel(List<string> errors)
        {
            Errors = errors;
        }

        //To see and add the error to the erros list
        public ResultViewModel(string error)
        {
            Errors.Add(error);
        }
    }
}
