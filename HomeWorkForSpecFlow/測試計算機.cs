using TechTalk.SpecFlow;

namespace HomeWorkForSpecFlow;

[Binding]

// 繼承Steps
public class 測試計算機 : Steps
{
    [Given(@"the first number is (.*)")]
    public void GivenTheFirstNumberIs(float firstNumber)
    {
        this.ScenarioContext.Set(firstNumber, "firstNumber");
    }

    [Given(@"the second number is (.*)")]
    public void GivenTheSecondNumberIs(float secondNumber)
    {
        this.ScenarioContext.Set(secondNumber, "secondNumber");
    }

    [When(@"the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        // get
        var firstNum = this.ScenarioContext.Get<float>("firstNumber");
        var secondtNum = this.ScenarioContext.Get<float>("secondNumber");

        var target = new Calucation();
        var sum = target.Add(firstNum,secondtNum);
        this.ScenarioContext.Set(sum,"actual");
    }

    [Then(@"the result should be (.*)")]
    public void ThenTheResultShouldBe(float expected)
    {
        var actual = this.ScenarioContext.Get<float>("actual");
        Assert.AreEqual(actual,expected);
    }

    [Given(@"第一個數字是(.*)")]
    public void Given第一個數字是(float firstNumber)
    {
        this.ScenarioContext.Set(firstNumber,"firstNumber");
    }

    [Given(@"第二個數字是(.*)")]
    public void Given第二個數字是(float secondNumber)
    {
        this.ScenarioContext.Set(secondNumber,"secondNumber");
    }

    [Given(@"第三個數字是(.*)")]
    public void Given第三個數字是(float thirdNumber)
    {
        this.ScenarioContext.Set(thirdNumber,"thirdNumber");
        
    }

    [When(@"三者數字計算")]
    public void When三者數字計算()
    {
        // 取得三個數字
        var firstNumber = this.ScenarioContext.Get<float>("firstNumber");
        var secondNumber = this.ScenarioContext.Get<float>("secondNumber");
        var thirdNumber = this.ScenarioContext.Get<float>("thirdNumber");
        var target= new Calucation();
        var firstRound = target.Add(firstNumber, secondNumber);
        var actual = target.相乘(firstNumber, secondNumber);
        this.ScenarioContext.Set(actual,"actual");
    }

    [Then(@"得出結果是(.*)")]
    public void Then得出結果是(float expected)
    {
        var actual = this.ScenarioContext.Get<float>("actual");
        Assert.AreEqual(expected,actual);
    }
}

public class Calucation
{
    public float Add(float firstNumber, float secondNumber)
    {
        return firstNumber + secondNumber;
    }

    public float 相乘(float firstNumber, float secondNumber)
    {
        return firstNumber * secondNumber;
    }
}