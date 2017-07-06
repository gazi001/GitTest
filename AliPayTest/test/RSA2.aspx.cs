using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AliPayTest.Com;
namespace AliPayTest.test
{
    public partial class RSA2 : System.Web.UI.Page
    {
        private LogHelper log = new LogHelper(AppDomain.CurrentDomain.BaseDirectory + "/log/log.txt");
        protected void Page_Load(object sender, EventArgs e)
        {
            //https://openauth.alipaydev.com/oauth2/publicAppAuthorize.htm?app_id=2016072900114972&scope=auth_user&redirect_uri=http%3a%2f%2fexamplezzh.tunnel.qydev.com%2ftest%2fRSA2.aspx&state=100
       
            var appid = Request.QueryString["app_id"];
            var scope = Request.QueryString["scope"];
            var auth_code = Request.QueryString["auth_code"];
            if (appid != null && scope != null && auth_code != null)
            {
                //IAopClient client = new DefaultAopClient(Config.serverUrl, Config.appId, Config.merchant_private_key, "json", Config.charset, "RSA2", Config.alipay_public_key);
                IAopClient client = new DefaultAopClient(Config.serverUrl, Config.appId, Config.merchant_private_key, "json", "1.0", "RSA2", Config.alipay_public_key, "utf-8", false);
                AlipaySystemOauthTokenRequest request = new AlipaySystemOauthTokenRequest();
                request.GrantType = "authorization_code";
                request.Code = auth_code;
              
                log.Write("auth_code:" + auth_code);
                AlipaySystemOauthTokenResponse response = client.Execute(request);
                log.Write("user_id:" + response.UserId+"/n");
                //AlipayUserUserinfoShareRequest userinfo = new AlipayUserUserinfoShareRequest();
                //AlipayUserUserinfoShareResponse userinforesponse = client.Execute(userinfo);
                //实例化具体API对应的request类,类名称和接口名称对应,当前调用接口名称：alipay.user.userinfo.share
                AlipayUserInfoShareRequest UserInforequest = new AlipayUserInfoShareRequest();
                ////授权类接口执行API调用时需要带上accessToken
               AlipayUserInfoShareResponse UserInforesponse = client.Execute(UserInforequest, response.AccessToken);
                Response.Write(UserInforesponse.Body);
                //Response.Write(userinforesponse.Body);
            }
        }
    }
}