using System.Linq.Expressions;

namespace TestesDesafio
{
    [TestClass]
    public class TestesUnitarios
    {
        //1 A Esses testes validam a verificação de parenteses no sistema
        [TestMethod()]
        public void EvaluateTest_Error1()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "2-(5+1";
            result = express.Evaluate();

            Assert.AreEqual("Error - Incomplete Brackets. The bracket ')' and position 5 was incomplete, fix and resubmit.", express.errorMessage);
            Assert.AreEqual("", result);
        }

        [TestMethod()]
        public void EvaluateTest_Error2()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "(5*2)-18/2)";
            result = express.Evaluate();

            Assert.AreEqual("Error - Incomplete Brackets. The bracket '(' and position 7 was incomplete, fix and resubmit.”", express.errorMessage);
            Assert.AreEqual("", result);
        }

        [TestMethod()]
        public void EvaluateTest_Error3()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "(8*1)*(12^2)+2/8)";
            result = express.Evaluate();

            Assert.AreEqual("Error - Incomplete Brackets. The bracket '(' and position 13 was incomplete, fix and resubmit.”", express.errorMessage);
            Assert.AreEqual("", result);
        }

        [TestMethod()]
        public void EvaluateTest_Error4()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "(4*2/2";
            result = express.Evaluate();

            Assert.AreEqual("Error - Incomplete Brackets. The bracket ')' and position 5 was incomplete, fix and resubmit.”", express.errorMessage);
            Assert.AreEqual("", result);
        }
        // 1 B Esses testes validam a verificação de numeros nas expressoes a serem calculadas 
        [TestMethod()]
        public void EvaluateTest_Error5()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "aa+bb+3";
            result = express.Evaluate();

            Assert.AreEqual("Error - Can not convert to number. Error 'aa' is not a number, ‘bb’ is not a number, fix and resubmit. ", express.errorMessage);
            Assert.AreEqual("", result);
        }
        public void EvaluateTest_Error6()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "10+bb+3 ";
            result = express.Evaluate();

            Assert.AreEqual("Error - Can not convert to number. Error 'bb' is not a number, fix and resubmit. ", express.errorMessage);
            Assert.AreEqual("", result);
        }

        public void EvaluateTest_Error7()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "ab+b*8^c ";
            result = express.Evaluate();

            Assert.AreEqual("Error - Can not convert to number. Error 'ab' is not a number, ‘b’ is not a number, ‘c’ is not a number , fix and resubmit. ", express.errorMessage);
            Assert.AreEqual("", result);
        }

        public void EvaluateTest_Error8()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "aa + bb + 3 ";
            result = express.Evaluate();

            Assert.AreEqual("Error - Can not convert to number. Error 'aa' is not a number, ‘bb’ is not a number, fix and resubmit. ", express.errorMessage);
            Assert.AreEqual("", result);
        }
        // 1 C Esse teste verifica se uma exceção foi lancada 
        [TestMethod()]
        public void EvaluateTest1()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "2-5+";
            result = express.Evaluate();

            Assert.AreEqual("1*6+8", express.results[0]);
            Assert.AreEqual("7+8", express.results[1]);
            Assert.AreEqual("15", express.results[2]);
            Assert.AreEqual("", express.errorMessage);

        }

        // 2 A Verifica o uso do novo operador '!'
        [TestMethod()]
        public void EvaluateTest1()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "8!4";
            result = express.Evaluate();

            Assert.AreEqual("((8*2)-(4/2))*10", express.results[0]);
            Assert.AreEqual("(16-(4/2))*10", express.results[1]);
            Assert.AreEqual("(16-2)*10", express.results[2]);
            Assert.AreEqual("14*10", express.results[3]);
            Assert.AreEqual("140", express.results[4]);
            Assert.AreEqual("140", result);
        }

        public void EvaluateTest2()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "4!2";
            result = express.Evaluate();

            Assert.AreEqual("((4*2)-(2/2))*10", express.results[0]);
            Assert.AreEqual("(8-(2/2))*10", express.results[1]);
            Assert.AreEqual("(8-1)*10", express.results[2]);
            Assert.AreEqual("7*10", express.results[3]);
            Assert.AreEqual("70", express.results[4]);
            Assert.AreEqual("70", result);
        }

        public void EvaluateTest3()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "16!8";
            result = express.Evaluate();

            Assert.AreEqual("((16*2)-(8/2))*10", express.results[0]);
            Assert.AreEqual("(32-(8/2))*10", express.results[1]);
            Assert.AreEqual("(32-6)*10", express.results[2]);
            Assert.AreEqual("26*10", express.results[3]);
            Assert.AreEqual("260", express.results[4]);
            Assert.AreEqual("260", result);
        }

        public void EvaluateTest4()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            express.rawValue = "7!5";
            result = express.Evaluate();

            Assert.AreEqual("((7*2)-(5/2))*10", express.results[0]);
            Assert.AreEqual("(14-(5/2))*10", express.results[1]);
            Assert.AreEqual("(14-2.5)*10", express.results[2]);
            Assert.AreEqual("11.5*10", express.results[3]);
            Assert.AreEqual("115", express.results[4]);
            Assert.AreEqual("115", result);
        }


        // 2 B  Verifica se o sistema aceita numeros negativos
        [TestMethod()]
        public void IsNumericTest1()
        {
            string value = "-5";

            Assert.AreEqual(true, value.IsNumeric());
        }
        [TestMethod()]
        public void IsNumericTest2()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            String value = "-2";
            express.rawValue = "(10-15)*(-2)";
            result = express.Evaluate();

            Assert.AreEqual("10", result);
            Assert.AreEqual(true, value.IsNumeric());

        }
        [TestMethod()]
        public void IsNumericTest3()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            String value = "-2";
            express.rawValue = "10*(-2)";
            result = express.Evaluate();

            Assert.AreEqual("-20", result);
            Assert.AreEqual(true, value.IsNumeric());
        }
        [TestMethod()]
        public void IsNumericTest4()
        {
            string result;
            Expression express = new DomainEntities.Expression();
            String value = "-4";
            express.rawValue = "((14/2)-8)+(-4)";
            result = express.Evaluate();

            Assert.AreEqual("-5", result);
            Assert.AreEqual(true, value.IsNumeric());
        }

    }
}