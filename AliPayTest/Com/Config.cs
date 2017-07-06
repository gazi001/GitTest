using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AliPayTest.Com
{
    public class Config
    {
        public static string alipay_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAv2TIeBRyaIW24KaAc/lxdOhRs7sKF7jdOLEai3mSkG5+6UKa9xMZBJpTr0Cl6h3uQZ56uTpTq5kl8lcgav6pjuHt0MOHUmBVxGcwCGGCYFnTr3benDXpC0MoZA2Kgpz7i472V2Ctaie7HE9xo8kpbFQqBRFIIHRIT6UkRYQC5H6w42TGVoyMZG4bV+rdDi/taSNt0K2bhRrTF46V5fG3JgInsHme2gEBbCsUXpB0xLWcC7ouNTEYe8EtrNrXXNqDY/0Km6Taoi93KkTlBr7mavdSUQumqF/bUcajeKVXmM0J915hwfQ9/pwgZ5OnPfggwwQDQwobiLc33ynLd0JsxwIDAQAB";


        //这里要配置没有经过的原始私钥

        //开发者私钥
        public static string merchant_private_key = "MIIEpAIBAAKCAQEA5VcRu1TwBww68KdlYgtqfZPDGh8HCNAHRdhCCzR5T/dTtizeXGaMk1pRRhF6jsLfFp+LoOy/9wIFgE8FrC4TPHSxbavDyEneJW6/foP8mJimqOUeLlcCb3H95QpFKdBZuYY8WVrx1Hk3irFZynbfJoel0HZHwcFMI30nroVTZm+on/NM8hRd2FC3Y5xchBhUBY2TyIrxoDHJKC8SOIK4RFiSlEdtyLhYjIRds0hfwMQ2M/B4mQck6Qs5VYiVabp1LDzHFrry1V40qwaADmBbv/nx+4Zo3BpVDhpvOZYNZ5de9IHNyklSSaj3TssaJgkK60BFtyoDx/YZHd3Y1tUXvwIDAQABAoIBABef23y/qCYhtWSa6c+qu2KKORvUvGXFACrKtyruUdzR7naispk0GyEGub6NCGHyYwaykrCWEsRAGg74lO4CpQqiPrC8c+OK8G5MtT80G24gs3JMf8poPiD6zhus7ij7hHKfCFJwEt8/SWBpGoXHrv8KFCOgO44S+mPhfZf1tfykK/pujF/7H9ZzXbUc5zi2+GMEbvkCWv5rMZXHRZS25Sc25vVCEPLNgKuyvNvYB7VEoBRfFHd1QyGmyV0ZhQ+Qw6ag2fzV3JxmYVYMDUKdvOUdu3OE3Xy6/iRTHn7pMvURW881W+IsjAcl6b5AUD+jMAIurWQzbuX31rnBo/uuhvECgYEA+ZP5mVUeryEX7zr4bHECkYAOZNSf/8MCSDAcEv1tMwsP0H/S5noFjSv0ogJih8y6rFegN7/BvnG0fCue+47Zc58PFmz/7eG5rfKp4+x53J3MSXK7Cffpypqkw6qvoDjPs1lPDFLW3A29JuuPgYxT2sriADDOvsfigfATNItYB5kCgYEA6z3IX+cmm0dZYyint5Z4ul57zxLPc9NRtS+1bxiiZj0csCzpsch7OSYcW8S7/x0XobZs0D4v8/M6QpwOmundNLDrFCPNPflUwH6YK8mCGihCfjSs2Da5Uv/eX/tdHz8S3vd9atYeKEgO0Y6S1O75WB5LZ0dNPDm5sW9hO7LNURcCgYEA2ZbSKIVWgBbZGCAQj/Ki65l6cxwQ9lnc9nTDNScvei3ttriKdZfymRa2bDyqDH1ITpMCwzfyQQg+83bQX782BCCrdcDIDGwchvQme+kigV4tyec1/EXg1VunxFNeVNDS/Ckjyrm6SxXLUFBUx/xA62KwULw8s4XvC5v0En5d3BkCgYAxxINkzrlbNpARq2M4MuxduWmGGJutDHMH2w0OcO7CpIEyQH48b4aqQ4bSX1/KjDQYsUh6Ef4BJV8ZAn0QhxOWdyt0ulJMnzgv9VhqQxp0QDo5CxnaMFGq3pkEQ2CjIKv0YfW1qZD9wqjn6rrjs58q5lXbhrkvWaMQh9jRUXWghwKBgQDtJvVTRXNGh+046kfeSGlZXs7BoQcjln0ntycZGqvvrW0KSp0NHDnONPuropcfg+09PuQXVKPG/NO386JikdwbLgEfg9LdPeRNGq9usBfa1aARpXgnuqCal0Y/ltwquKyDt5cBu/XyiOnNd9HbhEhCVaDnAHiRXhF/qjSGP5Ecsg==";

        //开发者公钥
        public static string merchant_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA5VcRu1TwBww68KdlYgtqfZPDGh8HCNAHRdhCCzR5T/dTtizeXGaMk1pRRhF6jsLfFp+LoOy/9wIFgE8FrC4TPHSxbavDyEneJW6/foP8mJimqOUeLlcCb3H95QpFKdBZuYY8WVrx1Hk3irFZynbfJoel0HZHwcFMI30nroVTZm+on/NM8hRd2FC3Y5xchBhUBY2TyIrxoDHJKC8SOIK4RFiSlEdtyLhYjIRds0hfwMQ2M/B4mQck6Qs5VYiVabp1LDzHFrry1V40qwaADmBbv/nx+4Zo3BpVDhpvOZYNZ5de9IHNyklSSaj3TssaJgkK60BFtyoDx/YZHd3Y1tUXvwIDAQAB";

        //应用ID
        public static string appId = "2016072900114972";

        //合作伙伴ID：partnerID
        public static string pid = "此处填写账号PID（partner id）";


        /// <summary>
        /// 支付宝网关
        /// </summary>
        public static string serverUrl = "https://openapi.alipaydev.com/gateway.do";
        public static string mapiUrl = "https://mapi.alipay.com/gateway.do";
        public static string monitorUrl = "http://mcloudmonitor.com/gateway.do";

        //编码，无需修改
        public static string charset = "utf-8";
        //签名类型，支持RSA2（推荐！）、RSA
        //public static string sign_type = "RSA2";
        public static string sign_type = "RSA2";
        //版本号，无需修改
        public static string version = "1.0";


        /// <summary>
        /// 公钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型公钥</returns>
        public static string getMerchantPublicKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_public_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

        /// <summary>
        /// 私钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型私钥</returns>
        public static string getMerchantPriveteKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_private_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

    }
}