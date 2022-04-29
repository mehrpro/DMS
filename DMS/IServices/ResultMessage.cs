namespace DMS.IServices
{
    public class ResultMessage
    {
        private string _resultCode;
        private string _errorMessage;
        private bool _success;

        public ResultMessage()
        {
            
        }

        public ResultMessage(bool success, string errorMessage, string resultCode) : this()
        {
            Success = success;
            ErrorMessage = errorMessage;
            ResultCode = resultCode;
        }

        public string ResultCode
        {
            get => _resultCode;
            set => _resultCode = value;
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => _errorMessage = value;
        }

        public bool Success
        {
            get => _success;
            set => _success = value;
        }
    }
}