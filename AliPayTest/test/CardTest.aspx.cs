using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aop.Api;
using Aop.Api.Request;
using Aop.Api.Response;
using AliPayTest.Com;
using Aop.Api.Domain;
namespace AliPayTest.test
{
    public partial class CardTest : System.Web.UI.Page
    {
        IAopClient client = new DefaultAopClient(Config.serverUrl, Config.appId, Config.merchant_private_key, "json", "1.0", "RSA2", Config.alipay_public_key, "utf-8", false);
        protected void Page_Load(object sender, EventArgs e)
        {
            //创建卡券模板
            AlipayPassTemplateAddRequest request = new AlipayPassTemplateAddRequest();
            AlipayPassTemplateAddModel model = new AlipayPassTemplateAddModel();
            model.UniqueId = "234774848495696";
            string File = Server.MapPath("~/test/json.txt");
            string CardString = System.IO.File.ReadAllText(File);
            model.TplContent= CardString;
           
            request.SetBizModel(model);
            AlipayPassTemplateAddResponse response = client.Execute(request);
            Response.Write(response.Body);
        }
    }
}