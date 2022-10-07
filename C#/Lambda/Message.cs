using System.ComponentModel;

namespace Lambda
{
    public enum Severity
    {
        [Description("调试：")]
        DEBUG,
        [Description("信息：")]
        INFO,
        [Description("告警：")]
        WARNING,
        [Description("错误：")]
        ERROR,
        [Description("严重错误：")]
        FATAL_ERROR
    }

    public class Message
    {
        public Message() { }
        public Message(Severity Severity, string? Text) 
        { 
            this.Severity = Severity;
            this.Text = Text;
        }
        public Severity Severity { get; set; }

        public string? Text { get; set; }
    }
}



