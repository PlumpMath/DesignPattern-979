// ********************************************
// 作者：洪根祥
// 时间：2017-03-08 20:59:49
// ********************************************

namespace Pattern.Creational
{
    public class SimpleFactotyMethod
    {
        /// <summary>
        /// 简单工厂，根据string返回相应的实例
        /// </summary>
        /// <param name="operate"></param>
        /// <returns></returns>
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "Add": operation = new Add(); break;
                case "Sub": operation = new Sub(); break;
                case "Mul": operation = new Mul(); break;
                case "Div": operation = new Div(); break;
            }
            return operation;
        }


        #region 操作对象

        public class Operation
        {

        }

        public class Add : Operation
        {

        }

        public class Sub : Operation
        {

        }

        public class Mul : Operation
        {

        }

        public class Div : Operation
        {

        } 
        #endregion
    }

}