// ********************************************
// 作者：洪根祥
// 时间：2017-03-08 21:09:14
// ********************************************

namespace Pattern.Creational
{
    public class FactoryMethod
    {

        public void Main()
        {
            IFactory operateFactory = new AddFactoty();
            var operation = operateFactory.CreateOperation();

        }

        interface IFactory
        {
            Operation CreateOperation();
        }

        class AddFactoty : IFactory
        {
            public Operation CreateOperation()
            {
                return new Add();
            }
        }

        class SubFactoty : IFactory
        {
            public Operation CreateOperation()
            {
                return new Sub();
            }
        }

        class MulFactoty : IFactory
        {
            public Operation CreateOperation()
            {
                return new Mul();
            }
        }



        #region 操作对象

        class Add : Operation
        {

        }

        class Sub : Operation
        {

        }

        class Mul : Operation
        {

        }

        class Div : Operation
        {

        } 
        #endregion

        //
        class Operation
        {

        }


    }




}