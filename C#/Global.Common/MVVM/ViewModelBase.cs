using Global.Common.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Global.Common
{
    /// <summary>
    /// 实例化一个Mode
    /// </summary>
    public abstract class ViewModelBase :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        /// <summary>
        /// 消息通知事件
        /// </summary>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "") {
            storage = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }
        protected virtual bool SetProperty1<T>(ref T storage, T value, [CallerMemberName] string propertyName = "") {
            VerifyAccess();
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;   
            storage = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }
        protected virtual void VerifyAccess() {
        }
    }

    /// <summary>
    /// .NET5 中，可以不使用string 直接使用变量，减少错误的可能，被nameof替代，和CallerMemberName
    /// </summary>
    public static class ViewModelBaseEx
    {
        public static void SetProperty<T, U>(this T tvm, Expression<Func<T, U>> expre) where T : ViewModelBase, new()
        {
            string _pro = GetPropertyName(expre);
            tvm.NotifyPropertyChanged(_pro);
        }

        public static string GetPropertyName<T, U>(Expression<Func<T, U>> expr)
        {
            string _propertyName = "";
            if (expr.Body is MemberExpression)
            {
                _propertyName = (expr.Body as MemberExpression).Member.Name;
            }
            else if (expr.Body is UnaryExpression)
            {
                _propertyName = ((expr.Body as UnaryExpression).Operand as MemberExpression).Member.Name;
            }
            return _propertyName;
        }
    }



    public abstract class ViewModelReg: ViewModelBase
    {
        public static string RegPath = "Software\\Grid";

        public static void WriteRegValue(object value, [CallerMemberName] string name = "") => Reg.WriteValue(RegPath, name, value);

        public static bool ReadRegValue(bool def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name, def);


        public static bool ReadRegValue([CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name);

        public static string ReadRegValue(string def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name,def);

        public static int ReadRegValue(int def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name, def);
    }

    public abstract class ViewModelJson : ViewModelBase
    {
        public static string RegPath = "Software\\Grid";

        public static void WriteJsonValue(object value, [CallerMemberName] string name = "") => Reg.WriteValue(RegPath, name, value);

        public static bool ReadJsonValue(bool def, [CallerMemberName] string name = "") => Reg.ReadValue(RegPath, name, def);
    }

}
