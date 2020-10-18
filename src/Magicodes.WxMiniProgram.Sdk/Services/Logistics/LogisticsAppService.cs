using Magicodes.WxMiniProgram.Sdk.Configs;
using Magicodes.WxMiniProgram.Sdk.Services.Logistics.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.WxMiniProgram.Sdk.Services.Logistics
{
    /// <summary>
    /// 物流助手
    /// </summary>
    public class LogisticsAppService : ServiceBase
    {
        private readonly IMiniProgramConfig _miniProgramConfig;
        private readonly string _BatchGetOrderUrl = "/cgi-bin/express/business/order/batchget?access_token={ACCESS_TOKEN}";
        private readonly string _AddOrderUrl = "/cgi-bin/express/business/order/add?access_token={ACCESS_TOKEN}";
        private readonly string _BindAccountUrl = "/cgi-bin/express/business/account/bind?access_token={ACCESS_TOKEN}";
        private readonly string _CancelOrderUrl = "/cgi-bin/express/business/order/cancel?access_token={ACCESS_TOKEN}";
        private readonly string _GetAllAccountUrl = "/cgi-bin/express/business/account/getall?access_token={ACCESS_TOKEN}";
        private readonly string _GetAllDeliveryUrl = "/cgi-bin/express/business/delivery/getall?access_token={ACCESS_TOKEN}";
        private readonly string _GetOrderUrl = "/cgi-bin/express/business/order/get?access_token={ACCESS_TOKEN}";
        private readonly string _GetPathUrl = "/cgi-bin/express/business/path/get?access_token={ACCESS_TOKEN}";
        private readonly string _GetPrinterUrl = "/cgi-bin/express/business/printer/getall?access_token={ACCESS_TOKEN}";
        private readonly string _GetQuotaUrl = "/cgi-bin/express/business/quota/get?access_token={ACCESS_TOKEN}";
        private readonly string _TestUpdateOrderUrl = "/cgi-bin/express/business/test_update_order?access_token={ACCESS_TOKEN}";
        private readonly string _UpdatePrinterUrl = "/cgi-bin/express/business/printer/update?access_token={ACCESS_TOKEN}";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="miniProgramConfig"></param>
        public LogisticsAppService(IMiniProgramConfig miniProgramConfig)
        {
            _miniProgramConfig = miniProgramConfig;
        }

        /// <summary>
        /// 批量获取运单数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<BatchGetOrderOutput> BatchGetOrder(BatchGetOrderInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<BatchGetOrderOutput>(_BatchGetOrderUrl, input);
        }

        /// <summary>
        /// 生成运单
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<AddOrderOutput> AddOrder(AddOrderInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<AddOrderOutput>(_AddOrderUrl, input);
        }

        /// <summary>
        /// 绑定、解绑物流账号
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<BindAccountOutput> BindAccount(BindAccountInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<BindAccountOutput>(_BindAccountUrl, input);
        }

        /// <summary>
        /// 取消运单
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CancelOrderOutput> CancelOrder(CancelOrderInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<CancelOrderOutput>(_CancelOrderUrl, input);
        }

        /// <summary>
        /// 获取所有绑定的物流账号
        /// </summary>
        /// <returns></returns>
        public async Task<GetAllAccountOutput> GetAllAccount()
        {
            return await HttpGet<GetAllAccountOutput>(_GetAllAccountUrl);
        }

        /// <summary>
        /// 获取支持的快递公司列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetAllDeliveryOutput> GetAllDelivery()
        {
            return await HttpGet<GetAllDeliveryOutput>(_GetAllDeliveryUrl);
        }

        /// <summary>
        /// 获取运单数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetOrderOutput> GetOrder(GetOrderInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<GetOrderOutput>(_GetOrderUrl, input);
        }

        /// <summary>
        /// 查询运单轨迹
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetPathOutput> GetPath(GetPathInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<GetPathOutput>(_GetPathUrl, input);
        }

        /// <summary>
        /// 获取打印员。若需要使用微信打单 PC 软件，才需要调用。
        /// </summary>
        /// <returns></returns>
        public async Task<object> GetPrinter()
        {
            return await HttpGet<GetPrinterOutput>(_GetPrinterUrl);
        }

        /// <summary>
        /// 获取电子面单余额。仅在使用加盟类快递公司时，才可以调用。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetQuotaOutput> GetQuota(GetQuotaInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<GetQuotaOutput>(_GetQuotaUrl, input);
        }

        /// <summary>
        /// 模拟快递公司更新订单状态, 该接口只能用户测试
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<TestUpdateOrderOutput> TestUpdateOrder(TestUpdateOrderInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<TestUpdateOrderOutput>(_TestUpdateOrderUrl, input);
        }

        /// <summary>
        /// 配置面单打印员，可以设置多个，若需要使用微信打单 PC 软件，才需要调用。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<UpdatePrinterOutput> UpdatePrinter(UpdatePrinterInput input)
        {
            input.AccessToken = AccessToken;

            return await HttpPost<UpdatePrinterOutput>(_UpdatePrinterUrl, input);
        }
    }
}
