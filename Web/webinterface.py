from main import *
from flask import  Blueprint,request




@server.route('/', methods=['get'])
def root():
    return render_template("index.html")

@server.route('/generateSNCode', methods=['get'])
def generateSNCode():
    return render_template("generateSNCode.html")


@server.route('/manager', methods=['get'])
def manager():
    return render_template("manager.html")

@server.route('/vendor', methods=['get'])
def vendor():
    return render_template("vendor.html")

@server.route('/vendoradd', methods=['get'])
def vendoradd():
    return render_template("vendoradd.html")

@server.route('/vendorlogin', methods=['get'])
def vendorlogin():
    return render_template("vendorlogin.html")

@server.route('/dragtest', methods=['get'])
def dragtest():
    return render_template("dragtest.html")

@server.route('/getRegion', methods=['get'])
def GetRegion():
    db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                         use_unicode=True)
    cursor = db.cursor()
    sql = "SELECT `name` FROM `grid`.`vendor`"
    num = cursor.execute(sql)
    vendor = cursor.fetchall()
    vendorlist = []
    for row in vendor:
        vendorlist.append(row[0]);

    print(vendorlist)

    resu = {'state': 0, 'message': '', 'list': vendorlist}
    return jsonify(resu)

import uuid

@server.route('/email_captcha/')
def email_captcha():
    print("22222")
    email = request.args.get('email')
    if not email:
        resu = {'code': 1, 'message': '请输入验证码'}
        return jsonify(resu)
    '''
    生成随机验证码，保存到memcache中，然后发送验证码，与用户提交的验证码对比
    '''
    captcha = str(uuid.uuid1())[:6]  # 随机生成6位验证码
    # 给用户提交的邮箱发送邮件
    try:
        smtp.receivers = email
        smtp.sendmail('Grid邮箱验证码','您的验证码是：%s' % captcha)  # 发送
        resu = {'code': 0, 'message': ''}
        return jsonify(resu)
    except Exception as e:
        resu = {'code': 1, 'message': e.args}
        return jsonify(resu)
        return


@server.route('/getModule', methods=['get'])
def GetModule():
    db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT, use_unicode=True)
    cursor = db.cursor()
    sql = "SELECT `name`,`code` FROM `grid`.`charging-module`"
    num = cursor.execute(sql)
    module = cursor.fetchall()
    modulelist = []
    for row in module:
        modulelist.append(row[0]);
    resu = {'state': 0, 'message': '', 'list': modulelist}
    return jsonify(resu)


import random, string

@server.route("/GeneraSNCode", methods=['post'])
def GeneraSNCode():
    vendor = request.values.get('vendor')
    moudle = request.values.get('moudle')

    if not vendor:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)

    db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                         use_unicode=True)
    cursor = db.cursor()
    sql = "SELECT `id`,`name` FROM `grid`.`vendor` WHERE `name` = '%s'" % (vendor);
    num = cursor.execute(sql);
    if (num == 0):
        resu = {'state': 1, 'message': '找不到供应商，请重新输入或者注册'}
        return jsonify(resu)

    vendor_id = cursor.fetchall()[0][0]
    sn = ''.join(random.sample(string.ascii_letters + string.digits, 24)).upper()

    sql = "INSERT INTO `grid`.`serial-number` (`sn`, `vendor_id`, `module_id`, `effect_months`,`create_date` ) VALUES ('%s', %s, 1, '%s','%s')" % (
    sn, vendor_id, time.strftime("%Y-%m-%d %H:%M:%S", time.localtime()),
    time.strftime("%Y-%m-%d %H:%M:%S", time.localtime()));
    print(sql)
    num = cursor.execute(sql);
    db.commit()
    print(sn)
    pattern = re.compile('.{6}')
    sn = '-'.join(pattern.findall(sn))
    # smtpdemo.receivers =["114803203@qq.com"]
    resu = {'state': 0, 'message': '', 'sn': sn}
    return jsonify(resu)


def sendemailSN(receivers, vendor, sn):
    smtp.receivers = receivers
    smtp.sendmail("Grid序列号", "尊敬的" + vendor + ":\n\r" + "您购买的序列号为： \n\r" + sn)


@server.route('/addSNCode', methods=['post'])
def addSNCode():
    sn = request.values.get('sn')
    print(sn)
    if not sn:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)
    if not checkSN(sn):
        resu = {'state': 1, 'message': '序列号参数异常'}
        return jsonify(resu)
    sn = sn.strip().replace("-", "")
    try:
        db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                             use_unicode=True)
        cursor = db.cursor()
        create_date = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
        sql = "INSERT INTO `grid`.`serial-number` (`sn`, `vendor_id`, `module_id`, `effect_months`, `create_date`) VALUES ('%s', %s, %s,'%s', '%s')" % (
        sn, 11, 11, create_date, create_date)
        print(sql)
        aa = cursor.execute(sql)
        db.commit()
        print(aa)
        if (aa == 0):
            resu = {'state': 0, 'message': '注册成功'}
            return jsonify(resu)  # 将字典转换为json串, json是字符串
        resu = {'state': 0, 'message': '注册成功'}
    except Exception:
        resu = {'state': 1, 'message': "数据库连接失败"}
    return jsonify(resu)  # 将字典转换为json串, json是字符串


from util import smtp
@server.route('/sendsmtp', methods=['post'])
def sendsmtp():
    print("发送邮件")
    subject = request.values.get('subject')
    content = request.values.get('content')
    receiver = request.values.get('receivers')
    if not subject and not content and not receiver:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)

    receivers =[receiver]
    smtp.receivers = receivers;
    print(content)
    code, msg = smtp.sendmail(subject, content)
    if code == 0:
        resu = {'state': code, 'message': msg}
        return jsonify(resu)
    else:
        resu = {'state': code, 'message': msg}
        return jsonify(resu)  # 将字典转换为json串, json是字符串



web_interface = Blueprint("web-interface", __name__)
@web_interface.route('/Userlogin1', methods=['get'])
def Userlogin1():
    print("Aaaa")
    return jsonify({'state': 0, 'message': '', 'userid': 0});