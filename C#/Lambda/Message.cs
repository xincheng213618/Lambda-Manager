using System.ComponentModel;

namespace Lambda
{
    public enum Severity
    {
        [Description("���ԣ�")]
        DEBUG,
        [Description("��Ϣ��")]
        INFO,
        [Description("�澯��")]
        WARNING,
        [Description("����")]
        ERROR,
        [Description("���ش���")]
        FATAL_ERROR
    }

    public class Message
    {
        public Message() 
        { 
        }
        public Message(string? Text)
        {
            this.Severity = Severity.INFO;
            this.Text = Text;
        }
        public Message(Severity Severity, string? Text) 
        { 
            this.Severity = Severity;
            this.Text = Text;
        }
        public Severity Severity { get; set; }

        public string? Text { get; set; }
    }
}



