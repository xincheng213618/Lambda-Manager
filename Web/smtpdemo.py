import smtplib
from email.mime.text import MIMEText
from email.header import Header
from email.mime.multipart import MIMEMultipart


# 写死的部分
mail_host = "smtp.qq.com"  # 设置服务器
mail_user = "1791746286@qq.com"  # 用户名
mail_pass = "dbabotmbvdwxdbdf"  # 口令


sender = '1791746286@qq.com'
# receivers = ['xincheng213618@gmail.com']  # 接收邮件，可设置为你的QQ邮箱或者其他邮箱
# receivers = ['114803203@qq.com']  # 接收邮件，可设置为你的QQ邮箱或者其他邮箱
receivers = ['1791746286@qq.com']


def sendmail(subject,content):
    # 第三方 SMTP 服务
    message =MIMEMultipart()
    message['From'] = mail_user
    # message['To'] = "xincheng213618@gmail.com'"
    message['To'] =receivers[0]
    message['Subject'] = Header(subject, 'utf-8')
    part1 = MIMEText(content, 'plain', 'utf-8')
    message.attach(part1)

    # addfile(message,filename)
    # addfile(message,"demo.py")

    try:
        s = smtplib.SMTP_SSL(mail_host, 465)
        s.login(mail_user, mail_pass)
        s.sendmail(mail_user, receivers, message.as_string())
        print("邮件发送成功")
        return "邮件发送成功"

    except smtplib.SMTPDataError as e :
        print(e.args)
        return e


def addfile(MIMENonMultipart,filename):
    part =MIMEText(open(filename, 'rb').read(), 'base64', 'utf-8')
    part["Content-Type"] = 'application/octet-stream'
    part.add_header('Content-Disposition', 'attachment',  filename=('gb2312', '',filename))
    MIMENonMultipart.attach(part)
    return MIMENonMultipart

