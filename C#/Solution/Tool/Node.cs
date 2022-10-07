using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Node<T>
    {
        public T Data { set; get; }          //数据域,当前结点数据
        public Node<T> Next { set; get; }    //位置域,下一个结点地址

        public Node(T item)
        {
            this.Data = item;
            this.Next = null;
        }

        public Node()
        {
            this.Data = default;
            this.Next = null;
        }
    }
}
