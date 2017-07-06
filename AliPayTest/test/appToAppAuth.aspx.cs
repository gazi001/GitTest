using AliPayTest.Com;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliPayTest.test
{
    public partial class appToAppAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //https://openauth.alipaydev.com/oauth2/appToAppAuth.htm?app_id=2016072900114972&redirect_uri=http%3a%2f%2fexamplezzh.tunnel.qydev.com%2ftest%2fappToAppAuth.aspx
            var app_auth_code = Request.QueryString["app_auth_code"];
            IAopClient client = new DefaultAopClient(Config.serverUrl, Config.appId, Config.merchant_private_key, "json", "1.0", "RSA2", Config.alipay_public_key, "utf-8", false);
            AlipayOpenAuthTokenAppRequest request = new AlipayOpenAuthTokenAppRequest();
            request.BizContent = "{" +
"    \"grant_type\":\"authorization_code\"," +
"    \"code\":" + app_auth_code + "" +
"  }";
            AlipayOpenAuthTokenAppResponse response = client.Execute(request);
            Response.Write(response.Body);
        }
    }
}