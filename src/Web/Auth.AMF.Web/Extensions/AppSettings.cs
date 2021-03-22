namespace Auth.AMF.Web.Extensions
{
    public class AppSettings
    {
        public MongoConnection MongoConnection { get; set; }
    }

    public class MongoConnection
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
