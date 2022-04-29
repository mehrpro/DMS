namespace DMS.IServices
{
    public class Sms
    {
        private long _mobile1;
        private long _mobile2;
        private string _reciverName1;
        private string _reciverName2;
        private string _content;

        public Sms(long mobile1 = default, long mobile2 = default, string reciverName1 = null, string reciverName2 = null, string content = null)
        {
            Mobile1 = mobile1;
            Mobile2 = mobile2;
            ReciverName1 = reciverName1;
            ReciverName2 = reciverName2;
            this.Content = content;
        }

        public long Mobile1
        {
            get => _mobile1;
            set => _mobile1 = value;
        }

        public long Mobile2
        {
            get => _mobile2;
            set => _mobile2 = value;
        }

        public string ReciverName1
        {
            get => _reciverName1;
            set => _reciverName1 = value;
        }

        public string ReciverName2
        {
            get => _reciverName2;
            set => _reciverName2 = value;
        }

        public string Content
        {
            get => _content;
            set => _content = value;
        }
    }
}