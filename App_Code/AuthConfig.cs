using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;

namespace BingSiteStyle1
{
    public static class AuthConfig
    {
        public static void RegisterOpenAuth()
        {
            // ��μ� http://go.microsoft.com/fwlink/?LinkId=252803������ϸ�˽���ν��� ASP.NET
            // Ӧ�ó�������Ϊ֧��ͨ���ⲿ�����¼��

            //OpenAuth.AuthenticationClients.AddTwitter(
            //    consumerKey: "��� Twitter ʹ������Կ",
            //    consumerSecret: "��� Twitter ʹ��������");

            //OpenAuth.AuthenticationClients.AddFacebook(
            //    appId: "��� Facebook Ӧ�ó��� ID",
            //    appSecret: "��� Facebook Ӧ�ó�������");

            //OpenAuth.AuthenticationClients.AddMicrosoft(
            //    clientId: "��� Microsoft �ʻ��ͻ��� ID",
            //    clientSecret: "��� Microsoft �ʻ��ͻ�������");

            //OpenAuth.AuthenticationClients.AddGoogle();
        }
    }
}