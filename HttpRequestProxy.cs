using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace ChromaFramework.Networking
{
    public class HttpRequestProxy
    {
        public NetworkCredential Credentials
        {
            get
            {
                if (this.WebProxy == null)
                {
                    return null;
                }
                return (NetworkCredential)this.WebProxy.Credentials;
            }
        }

        public System.Net.WebProxy WebProxy
        {
            get;
            private set;
        }

        public HttpRequestProxy()
        {
            this.WebProxy = null;
        }

        public HttpRequestProxy(string host)
        {
            this.WebProxy = new System.Net.WebProxy(host);
        }

        public HttpRequestProxy(string host, int port)
        {
            this.WebProxy = new System.Net.WebProxy(host, port);
        }

        public HttpRequestProxy(string host, string username, string password)
        {
            this.WebProxy = new System.Net.WebProxy(host)
            {
                Credentials = new NetworkCredential(username, password)
            };
        }

        public HttpRequestProxy(string host, int port, string username, string password)
        {
            this.WebProxy = new System.Net.WebProxy(host, port)
            {
                Credentials = new NetworkCredential(username, password)
            };
        }

        public void SetCredentials(string username, string password)
        {
            this.WebProxy.Credentials = new NetworkCredential(username, password);
        }
    }
}