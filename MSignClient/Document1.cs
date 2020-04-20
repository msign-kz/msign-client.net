using System.Text.Json.Serialization;

namespace MSignClient
{
    public class Document1
    {
        public string name { get; set; }
        public string description { get; set; }
        public string filename { get; set; }
        public string mimeType { get; set; }
        public string base64 { get; set; }
        public string keyCategory { get; set; }
        public string signType { get; set; }

        public bool restricted = false;

        public string[] restrictedTo = new string[] { };
    }

    public class Document1Response
    {
        public string id { get; set; }
        public string url { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
    }

    public enum KeyCategory
    {
        SIGNATURE, AUTHENTICATION
    }

    public enum SignType
    {
        XMLDSIG, PKCS7
    }
}
