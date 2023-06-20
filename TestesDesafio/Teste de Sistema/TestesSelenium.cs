using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestesDesafio
{
    [TestClass]
    public class TestesSelenium
    {
        public IWebDriver driver;

        // Teste que valida se o campo de expressao e o botao de solve sao interativos ou nao 
        [TestMethod]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("20+12");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.Quit();

        }

        // Teste que valida a operacao de adicao
        [TestMethod]
        public void TestMethod2()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("2+2");
            driver.FindElement(By.Id("btnSolve")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("4"));
            driver.Quit();
        }

        // Teste que valida a operacao de multiplicacao
        [TestMethod]
        public void TestMethod3()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("2*10");
            driver.FindElement(By.Id("btnSolve")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("20"));
            driver.Quit();
        }

        // Teste que valida a operacao de divisao
        [TestMethod]
        public void TestMethod4()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("10/2");
            driver.FindElement(By.Id("btnSolve")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("5"));
            driver.Quit();
        }
        // Teste que valida a operacao de potenciacao
        [TestMethod]
        public void TestMethod5()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("2^3");
            driver.FindElement(By.Id("btnSolve")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("8"));
            driver.Quit();
        }

        // Teste que valida a operacao de subtracao
        [TestMethod]
        public void TestMethod6()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("25-14");
            driver.FindElement(By.Id("btnSolve")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("11"));
            driver.Quit();
        }

        // Teste que valida a operacao de uma expressao com diversos operadores
        [TestMethod]
        public void TestMethod7()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);        
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("3+1*(10/2)");
            driver.FindElement(By.Id("btnSolve")).Click();
            Assert.IsTrue( driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("8"));
            driver.Quit();      
        }

        // Teste que valida a operacao de uma expressao de multiplicacao com numeros negativos
        [TestMethod]
        public void TestMethod8()
        { 
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("-2*6");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='-12']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\'calculatorForm\']/p[3]/b")).Text.Contains("-12"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma adicao com numeros negativos
        [TestMethod]
        public void TestMethod9()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("-2+3");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='1']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("1"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma subtracao com numeros negativos
        [TestMethod]
        public void TestMethod10()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("-2-8");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='-10']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("-10"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma divisao com numeros negativos
        [TestMethod]
        public void TestMethod11()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("-12/3");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='-4']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("-4"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma expressao com parenteses 
        [TestMethod]
        public void TestMethod12()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("(10/2)+(4*3)");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='5+(4*3)']"));
            driver.FindElement(By.XPath("//li[text()='5+12']"));
            driver.FindElement(By.XPath("//li[text()='17']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("17"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma expressao com parenteses e verifica a prioridade deles
        [TestMethod]
        public void TestMethod13()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("1+(4*3)");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='1+12']"));
            driver.FindElement(By.XPath("//li[text()='13']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("13"));
            driver.Quit();
        }

        // Teste que valida a operacao de uma expressao com parenteses e multiplicacao e verifica a prioridade deles
        [TestMethod]
        public void TestMethod14()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("(17/2)*3");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='8,5*3']"));
            driver.FindElement(By.XPath("//li[text()='25,5']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("25,5"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma expressao com parenteses e multiplicacao e verifica a prioridade deles
        [TestMethod]
        public void TestMethod15()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("-2+3");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='1']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("1"));
            driver.Quit();
        }
        // Teste que valida a operacao de uma expressao de subtracao com numeros decimais 
        [TestMethod]
        public void TestMethod16()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("2.5-3.5");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='-1']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("-1"));
            driver.Quit();  
        }
        // Teste que valida a operacao de uma expressao com parenteses e multiplicacao do numero 0
        [TestMethod]
        public void TestMethod17()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("(0*10)+(2*20)");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='0+(2*20)']"));
            driver.FindElement(By.XPath("//li[text()='0+40']"));
            driver.FindElement(By.XPath("//li[text()='40']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("40"));
            driver.Quit();     
        }
        // Teste que valida a operacao de uma expressao com parenteses e multiplicacao e verifica a prioridade dos chaves colchetes 
        [TestMethod]
        public void TestMethod18()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("(0*10)+[(2*20)+(3*18)]+{[(18*2)+(10*2)]}");
            driver.FindElement(By.Id("btnSolve")).Click();
            driver.FindElement(By.XPath("//li[text()='0+[(2*20)+(3*18)]+{[(18*2)+(10*2)]}']"));
            driver.FindElement(By.XPath("//li[text()='0+[40+(3*18)]+{[(18*2)+(10*2)]}"));
            driver.FindElement(By.XPath("//li[text()='0+[40+54]+{[(18*2)+(10*2)]}']"));
            driver.FindElement(By.XPath("//li[text()='0+[40+54]+{[36+(10*2)]}']"));
            driver.FindElement(By.XPath("//li[text()='0+[40+54]+{[36+20]}']"));
            driver.FindElement(By.XPath("//li[text()='0+94+{[36+20]}']"));
            driver.FindElement(By.XPath("//li[text()='0+94+56']"));
            driver.FindElement(By.XPath("//li[text()='150']"));
            Assert.IsTrue(driver.FindElement(By.XPath("//*[@id=\"calculatorForm\"]/p[3]/b")).Text.Contains("150"));
            driver.Quit();
        }

        // Teste que valida se a mensagem de expressao invalida esta com as letras vermelhas 
        [TestMethod]
        public void TestMethod19()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("1+(4*3");
            driver.FindElement(By.Id("btnSolve")).Click();
            String color = driver.FindElement(By.XPath("//p[text()='Error - Invalid expression.']")).GetCssValue("color");
            Assert.AreEqual("red", color);
        }

        // Teste que valida se o sistema avisa que o campo de expressao esta vazio fazendo com que o sistema nao chame pela a operacao de calcular no backend
        [TestMethod]
        public void TestMethod20()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:2539/Calculator/Calculator");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.Id("expression")).Click();
            driver.FindElement(By.Id("expression")).SendKeys("");
            driver.FindElement(By.Id("btnSolve")).Click();
            String color = driver.FindElement(By.XPath("//p[text()='Warning - Expression field is empyt! Please fild the field.']")).GetCssValue("color");
            Assert.AreEqual("red", color);
        }
    }
}