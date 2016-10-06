using System;
using System.Web;
using System.Linq;
namespace ShortUrl
{
    public class Redirecting : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.BeginRequest += new EventHandler(OnBeginRequest);
        }

        #endregion
      
        public void OnBeginRequest(Object source, EventArgs e)
        {
            
            var context = (HttpApplication)source;
            var path = context.Request.Url.AbsolutePath.Remove(0, 1);
            var id = path.ToDecimal();
                using (var DBcontext = new ShortUrlEntities())
                {
                    var query = from item in DBcontext.Main
                                where  item.id== id
                                select item.original_url;

                var redirectPath= query.FirstOrDefault();
                if(redirectPath!=null)  context.Response.Redirect(redirectPath);
                    }
                    
                }
            
        }
    }

