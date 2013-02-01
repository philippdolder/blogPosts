namespace pcl.fakeiteasy
{
    public class Provider
    {
        private readonly IService service;

        public Provider(IService service)
        {
            this.service = service;
        }

        public string Provide()
        {
            return this.service.Get();
        }
    }
}