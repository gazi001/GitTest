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
            AlipayPassTemplateAddRequest request = new AlipayPassTemplateAddRequest();
            AlipayPassTemplateAddModel model = new AlipayPassTemplateAddModel();

            request.BizContent = "{" +
            "\"unique_id\":\"20140709150010\"," +
            "\"tpl_content\":\"{\\\"logo\\\": \\\"\\\",\\\"strip\\\": null,\\\"icon\\\": null,\\\"content\\\": {}}\"" +
            "  }";
            AlipayPassTemplateAddResponse response = client.Execute(request);
            Console.WriteLine(response.Body);

        }
    }
}