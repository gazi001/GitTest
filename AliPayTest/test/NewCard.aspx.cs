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
using Aop.Api.Domain;
namespace AliPayTest.test
{
    public partial class NewCard : System.Web.UI.Page
    {
        IAopClient client = new DefaultAopClient(Config.serverUrl, Config.appId, Config.merchant_private_key, "json", "1.0", "RSA2", Config.alipay_public_key, "utf-8", false);
        protected void Page_Load(object sender, EventArgs e)
        {
            //新建卡
            AlipayPassInstanceAddRequest request = new AlipayPassInstanceAddRequest();
            AlipayPassInstanceAddModel model = new AlipayPassInstanceAddModel();
            request.BizContent = "{" +
            "\"tpl_id\":\"2017070616555935516915129\"," +
            "\"tpl_params\":\"{\\\"message\\\":\\\"https://alipass.alipay.com//temps/free/logo.png\\\"}\"," +
            "\"recognition_type\":\"1\"," +
            "\"recognition_info\":\"{\\\"partner_id\\\":\\\"2088102168948072\\\",\\\"out_trade_no\\\":\\\"10000028484001\\\"}\"" +
            "  }";
            AlipayPassInstanceAddResponse response = client.Execute(request);

        }
    }
}