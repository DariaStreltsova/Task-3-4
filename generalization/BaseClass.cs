using System;

namespace generalization
{
    abstract class BaseClass<T> : IPrinter
    {
        protected abstract void UserInput();
        protected abstract void RandomInput();

        public abstract void Print();
        protected bool InputByUser;
        protected IBase<T> type;
        public BaseClass(IBase<T> type, bool InputByUser)
        {
            this.InputByUser = InputByUser;
            this.type = type;
            Choice();
        }
         protected void Choice(){
            if(!InputByUser){
                RandomInput();
            }
            else{
                UserInput();
            }
        }
    }
}