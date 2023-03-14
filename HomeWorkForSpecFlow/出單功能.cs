using System.Collections.Generic;
using System.Linq;
using HomeWorkForSpecFlow.TransferShipping;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HomeWorkForSpecFlow;

[Binding]
public class 出單功能 : Steps
{
    [Given(@"輸入出單號碼")]
    public void Given輸入出單號碼(Table table)
    {
        // 建立一個篩選的模型
        var filter = table.CreateInstance<FilterShippingModel>();
        ScenarioContext.Current.Set(filter, "filter");
    }

    [Given(@"已存在出單清單")]
    public void Given已存在出單清單(Table table)
    {
        var existData = table.CreateSet<TransferShipping.TransferShippingViewModel>();
        ScenarioContext.Current.Set(existData, "transferShippings");
    }

    [When(@"按下送出")]
    public void When按下送出()
    {
        var filter = ScenarioContext.Current.Get<FilterShippingModel>("filter");
        var shippingLogic = new ShippingLogic(); 
        var transferShippings = ScenarioContext.Current.Get<IEnumerable<TransferShipping.TransferShippingViewModel>>("transferShippings");
        shippingLogic._transferShippingViewModels = transferShippings.ToList();
        var actual = shippingLogic.QueryStatus(filter);
        ScenarioContext.Set(actual, "actual");
    }

    [Then(@"結果為(.*)")]
    public void Then結果為(int expected)
    {
        var actual = this.ScenarioContext.Get<int>("actual");
        Assert.AreEqual(expected, actual);
    }
}