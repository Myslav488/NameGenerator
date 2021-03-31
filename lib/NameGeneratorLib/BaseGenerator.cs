using System;
namespace NameGeneratorLib
{
    public abstract class BaseGenerator
    {
        protected abstract string result{ get; set; }
        protected abstract int length { get; set; }
        public abstract void ShowResult();
        public abstract void SubMenu();
        public abstract void PerformAction(int choice);
    }   
}