using ChromaFramework;
using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;

namespace ChromaFramework.Networking
{
    public class HttpRequestHandler
    {
        public bool AutoRedirect
        {
            get;
            set;
        }

        public CookieContainer Cookies
        {
            get;
            private set;
        }

        public string LocationUrl
        {
            get;
            private set;
        }

        public HttpRequestProxy Proxy
        {
            get;
            set;
        }

        public string UserAgent
        {
            get;
            set;
        }

        public HttpRequestHandler()
        {
            this.AutoRedirect = true;
            this.LocationUrl = "";
            this.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:51.0) Gecko/20100101 Firefox/51.0";
            this.Cookies = new CookieContainer();
            this.Proxy = new HttpRequestProxy();
        }

        public static string Create(string url)
        {
            return (new HttpRequestHandler()).Get(url);
        }

        public static string Create(string url, string data)
        {
            return (new HttpRequestHandler()).Post(url, data);
        }

        public string Get(string url)
        {
            string end;
            string empty;
            ICredentials credentials;
            HttpWebRequest autoRedirect = WebRequest.CreateHttp(url);
            autoRedirect.AllowAutoRedirect = this.AutoRedirect;
            autoRedirect.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            autoRedirect.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            autoRedirect.CookieContainer = this.Cookies;
            autoRedirect.Method = "GET";
            autoRedirect.Referer = this.LocationUrl;
            autoRedirect.UseDefaultCredentials = false;
            autoRedirect.Proxy = this.Proxy.WebProxy;
            HttpWebRequest httpWebRequest = autoRedirect;
            if (this.Proxy.WebProxy == null)
            {
                credentials = null;
            }
            else
            {
                credentials = this.Proxy.Credentials;
            }
            httpWebRequest.Credentials = credentials;
            autoRedirect.UserAgent = this.UserAgent;
            try
            {
                HttpWebResponse response = (HttpWebResponse)autoRedirect.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        end = streamReader.ReadToEnd();
                    }
                }
                this.LocationUrl = response.ResponseUri.OriginalString;
                response.Dispose();
                return end;
            }
            catch
            {
                empty = string.Empty;
            }
            return empty;
        }

        public string[] Head(string url)
        {
            string[] strArrays;
            HttpWebRequest autoRedirect = WebRequest.CreateHttp(url);
            autoRedirect.AllowAutoRedirect = this.AutoRedirect;
            autoRedirect.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            autoRedirect.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            autoRedirect.CookieContainer = this.Cookies;
            autoRedirect.Method = "HEAD";
            autoRedirect.Referer = this.LocationUrl;
            autoRedirect.UseDefaultCredentials = false;
            autoRedirect.UserAgent = this.UserAgent;
            try
            {
                HttpWebResponse response = (HttpWebResponse)autoRedirect.GetResponse();
                string[] allKeys = response.Headers.AllKeys;
                response.Dispose();
                return allKeys;
            }
            catch
            {
                strArrays = new string[0];
            }
            return strArrays;
        }

        public string Post(string url, string data)
        {
            string end;
            string empty;
            ICredentials credentials;
            HttpWebRequest autoRedirect = WebRequest.CreateHttp(url);
            autoRedirect.AllowAutoRedirect = this.AutoRedirect;
            autoRedirect.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            autoRedirect.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            autoRedirect.CookieContainer = this.Cookies;
            autoRedirect.ContentType = "application/x-www-form-urlencoded";
            autoRedirect.Method = "POST";
            autoRedirect.UseDefaultCredentials = false;
            autoRedirect.Proxy = this.Proxy.WebProxy;
            HttpWebRequest httpWebRequest = autoRedirect;
            if (this.Proxy.WebProxy == null)
            {
                credentials = null;
            }
            else
            {
                credentials = this.Proxy.Credentials;
            }
            httpWebRequest.Credentials = credentials;
            autoRedirect.Referer = this.LocationUrl;
            autoRedirect.UserAgent = this.UserAgent;
            byte[] bytes = Encoding.Default.GetBytes(data);
            autoRedirect.ContentLength = (long)bytes.Length;
            using (Stream requestStream = autoRedirect.GetRequestStream())
            {
                requestStream.Write(bytes, 0, (int)bytes.Length);
            }
           /* try
            {*/
                HttpWebResponse response = (HttpWebResponse)autoRedirect.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        end = streamReader.ReadToEnd();
                    }
                }
                this.LocationUrl = response.ResponseUri.OriginalString;
                response.Dispose();
                return end;
            /*}
            catch
            {
                empty = string.Empty;
            }*/
            return empty;
        }

        public byte[] PostBytes(string url, string data)
        {
            string end;
            byte[] empty;
            ICredentials credentials;
            HttpWebRequest autoRedirect = WebRequest.CreateHttp(url);
            autoRedirect.AllowAutoRedirect = this.AutoRedirect;
            autoRedirect.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            autoRedirect.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            autoRedirect.CookieContainer = this.Cookies;
            autoRedirect.ContentType = "application/x-www-form-urlencoded";
            autoRedirect.Method = "POST";
            autoRedirect.UseDefaultCredentials = false;
            autoRedirect.Proxy = this.Proxy.WebProxy;
            HttpWebRequest httpWebRequest = autoRedirect;
            if (this.Proxy.WebProxy == null)
            {
                credentials = null;
            }
            else
            {
                credentials = this.Proxy.Credentials;
            }
            httpWebRequest.Credentials = credentials;
            autoRedirect.Referer = this.LocationUrl;
            autoRedirect.UserAgent = this.UserAgent;
            byte[] bytes = Encoding.Default.GetBytes(data);
            autoRedirect.ContentLength = (long)bytes.Length;
            using (Stream requestStream = autoRedirect.GetRequestStream())
            {
                requestStream.Write(bytes, 0, (int)bytes.Length);
            }
            try
            {
                HttpWebResponse response = (HttpWebResponse)autoRedirect.GetResponse();
                MemoryStream ms = new MemoryStream();
                response.GetResponseStream().CopyTo(ms);
                this.LocationUrl = response.ResponseUri.OriginalString;
                response.Dispose();
                empty = ms.ToArray();
            }
            catch
            {
                empty = new byte[] { };
            }
            return empty;
        }

        public string UrlDecode(string url)
        {
            return Uri.UnescapeDataString(url);
        }

        public string UrlEncode(string url)
        {
            return Uri.EscapeUriString(url);
        }
    }
}