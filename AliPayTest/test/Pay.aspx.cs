using AliPayTest.Com;
using Aop.Api;
using Aop.Api.Domain;
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
    public partial class Pay : System.Web.UI.Page
    {
        IAopClient client = new DefaultAopClient(Config.serverUrl, Config.appId, Config.merchant_private_key, "json", "1.0", "RSA2", Config.alipay_public_key, "utf-8", false);
        protected void Page_Load(object sender, EventArgs e)
        {
            //IAopClient client = new DefaultAopClient("https://openapi.alipay.com/gateway.do", "app_id", "merchant_private_key", "json", "1.0", "RSA2", "alipay_public_key", "GBK", false);
            //网页端支付方法
            //AlipayTradePagePayRequest request = new AlipayTradePagePayRequest();
            //request.BizContent = "{" +
            //"    \"body\":\"Iphone6 16G\"," +
            //"    \"subject\":\"Iphone6 16G\"," +
            //"    \"out_trade_no\":\"201503200101010045\"," +
            //"    \"total_amount\":21.24," +
            //"    \"product_code\":\"FAST_INSTANT_TRADE_PAY\"" +
            //"  }";
            //request.SetReturnUrl("http://examplezzh.tunnel.qydev.com");
            //AlipayTradePagePayResponse response = client.pageExecute(request);
            //string form = response.Body;
            //Response.Write(form);

            //手机网页支付方法
            AlipayTradeWapPayRequest request = new AlipayTradeWapPayRequest();
            //创建支付信息实体
            AlipayTradeWapPayModel model = new AlipayTradeWapPayModel();
            model.SellerId = "2088102168948072";
            model.Subject = "测试支付";
            model.TotalAmount = "100.00";
            model.OutTradeNo = "1000002838499";
            model.ProductCode = "QUICK_WAP_WAY";
            model.TimeoutExpress = "90m";
            request.SetBizModel(model);
            //设置支付完成后跳转页面
            request.SetReturnUrl("http://examplezzh.tunnel.qydev.com");
            AlipayTradeWapPayResponse response = client.pageExecute(request);
            string form = response.Body;
            Response.Write(form);
            // http://examplezzh.tunnel.qydev.com/test/Pay.aspx
        }
        /// <summary>
        /// 根据订单号查询交易状态
        /// </summary>
        public void QueryOrder()
        {
            AlipayTradeQueryRequest request = new AlipayTradeQueryRequest();
            AlipayTradeQueryModel model = new AlipayTradeQueryModel();
            model.OutTradeNo = "1000002838499";
            request.SetBizModel(model);
            AlipayTradeQueryResponse response = client.Execute(request);
            Console.WriteLine(response.Body);

        }
    }
}