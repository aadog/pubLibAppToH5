using System.Net;

namespace libAppToH5;

[TestClass]
public class Test1
{
    [TestMethod]
    public async Task TestMethod1()
    {
        using var httpClient = new HttpClient(new HttpClientHandler()
        {
            AutomaticDecompression = DecompressionMethods.All
        });
        var ret=await AppToH5Convert.Go("app_id=2019010862808682&biz_content=%7B%22timeout_express%22%3A%2230m%22%2C%22time_expire%22%3A%222025-08-30+20%3A34%3A27%22%2C%22product_code%22%3A%22QUICK_MSECURITY_PAY%22%2C%22total_amount%22%3A1.00%2C%22subject%22%3A%22%E4%B8%BA183****7606%E8%AF%9D%E8%B4%B9%E5%85%85%E5%80%BC%22%2C%22out_trade_no%22%3A%2200552025083020042741542973155578%22%7D&charset=utf-8&method=alipay.trade.app.pay&notify_url=https%3A%2F%2Fjkjhdr.cmft.com.cn%2Fvpc%2Fnotify%2Falipay%2Fpayment%2Fv1%2FnotifyAlipay&sign=V2mtYSBmVNTJnw4BAAagEh3A8dkyhFalBUuowlDBLSMHF3t07pWKeS%2FwgzZPBH6a11jGad7pBMoPkIBGOqu7azZ30yOjtAgcy08OsnPVO1QaEOJtPF1G1l89tVIc7hwKgd%2BTcD5TzCV%2BuqoFkc1RNxS04RENpxG%2FS5qObkuGywXa0joSkGtrzBBF%2FaqcwFlx3dTCBiZz7UucALOA9MPYLdxlAX0AArnUga%2BfO7ZZxd4i6qmQBbTOpzkBddhbtJF68Fv7E6vSqD34GWYw9JrdLVDiI%2FqJj80WmPJpGe4ELajhTUOuAuuFxSStxEtSKtN2N43%2FuVUK6D6dYSo5VMFpMQ%3D%3D&sign_type=RSA2&timestamp=2025-08-30+20%3A04%3A27&version=1.0", httpClient);
        Console.WriteLine(ret);
        //https://mclient.alipay.com/cashierRoutePay.htm?route_pay_from=h5&init_from=SDKLite&session=RZZFB10CvETSqZEEVwQ0GIGGa3sDTkmobilecashierRZZFB10&utdid=e02a7e72053f4ebf85ccc352052bd00b&tid=df17a9f8c55f1d1c445df68a0ec25a5be1f0ad73eb8bd29b4320a9670f527e79&cc=y
    }
}
