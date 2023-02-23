import flask, json
from flask import render_template, request, jsonify

import time

import pymysql.cursors

HOST = 'xc213618.ddns.me'
USER = 'root'
PASSWD = 'xincheng'
DB = 'grid'
PORT = 3306
CHARSET = 'utf8'

# 创建一个服务，把当前这个python文件当做一个服务
server = flask.Flask(__name__, static_folder='', static_url_path='')


@server.route('/Userlogin', methods=['post'])
def Userlogin():
    name = request.values.get('name')
    legal_address = request.values.get('legal_address')
    email_address = request.values.get('email_address')
    contact_number = request.values.get('contact_number')
    user_class = request.values.get('user_class')
    if not name:
        resu = {'state': 1, 'message': '姓名不能为空'}
        return jsonify(resu)

    db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT, use_unicode=True)
    cursor = db.cursor()
    sql = "SELECT * FROM  `user` WHERE `name` = '%s'" % (name);
    print(sql)
    if (cursor.execute(sql) != 0):
        return {'state': 0, 'message': '', 'userid': cursor.fetchall()[0][0]};
    else:
        create_date = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
        sql = "INSERT INTO `user` (name, legal_address, email_address, contact_number,user_class) \
               VALUES (%s, '%s', '%s','%s',%s)" % \
              (name, legal_address, email_address, contact_number, 0)
        print(sql)
        cursor.execute(sql)
        db.commit()
        sql = "SELECT * FROM  `user` WHERE `name` = '%s'" % (name);
        cursor.execute(sql)
        return {'state': 0, 'message': '', 'userid': cursor.fetchall()[0][0]};


@server.route('/register', methods=['post'])
def register():
    user_id = 1
    sn = request.values.get('sn')
    register_info = request.values.get('register-info')
    mac_address = request.values.get('mac-address')
    equip_identify = request.values.get('equip-identify')

    if not sn or not mac_address or not register_info:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)
    if not checkSN(sn):
        resu = {'state': 1, 'message': '序列号参数异常'}
        return jsonify(resu)
    if not checkMac(mac_address):
        resu = {'state': 1, 'message': 'Mac地址参数异常'}
        return jsonify(resu)

    sn = sn.strip().replace("-", "")
    mac_address = mac_address.strip().replace("-", "").replace(":", "").replace(".", "")

    if register_info:
        try:
            db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                                 use_unicode=True)
            cursor = db.cursor()

            try:
                register_info = json.loads(register_info)
                name = register_info["name"]
                legal_address = register_info["legal_address"]
                email_address = register_info["email_address"]
                contact_number = register_info["contact_number"]
                sql = "SELECT * FROM  `user` WHERE `name` = '%s'" % (name);
                num = cursor.execute(sql)
                result = cursor.fetchall();
                if num == 0:
                    print("找不到用户信息，现在重新插入用户信息")
                    sql = "INSERT INTO `user` (name, legal_address, email_address, contact_number,user_class) \
                           VALUES ('%s', '%s', '%s','%s',0)" % \
                          (name, legal_address, email_address, contact_number)
                    num = cursor.execute(sql)
                    result = cursor.fetchall();
                    print(result)
                    user_id = result[0][0]
                    db.commit()
                else:
                    user_id = result[0][0]

            except:
                resu = {'state': 1, 'message': "用戶信息格式不正确，请检查register_info"}
                return jsonify(resu)  # 将字典转换为json串, json是字符串

            sql = "SELECT * FROM  `serial-number` WHERE `sn` = '%s'" % (sn.strip().replace("-", ""));
            print(sql)
            aa = cursor.execute(sql)
            if (aa == 0):
                resu = {'state': 1, 'message': "该序列号无效"}
                return jsonify(resu)  # 将字典转换为json串, json是字符串

            sql = "SELECT * FROM  `register-info` WHERE `sn` = '%s'" % (sn);
            print(sql)
            aa = cursor.execute(sql)
            if (aa != 0):
                bb = cursor.fetchall();
                print(bb[0])
                if bb[0][3] != mac_address and bb[0][1] == user_id:
                    resu = {'state': 1, 'message': "该用户已经注册过，是否重新注册到新设备？"}
                    return jsonify(resu)  # 将字典转换为json串, json是字符串
                else:
                    resu = {'state': 1, 'message': "该序列号已经注册"}
                    return jsonify(resu)  # 将字典转换为json串, json是字符串

            sql = "SELECT * FROM  `register-info` WHERE `mac_address` = '%s'" % (mac_address);
            num = cursor.execute(sql)

            create_date = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
            sql = "INSERT INTO `register-info` (user_id, equip_identify, mac_address, sn,create_date) \
                   VALUES (%s, '%s', '%s','%s','%s')" % \
                  (user_id, equip_identify, mac_address, sn, create_date)
            print(sql)
            num = cursor.execute(sql)
            db.commit()

            resu = {'state': 0, 'message': "注册成功", 'user-class': 0, 'feature-list': [{"Moudlue": "基础版本"}]}
            return jsonify(resu)  # 将字典转换为json串, json是字符串

            # if (num==0):
            #     create_date = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
            #     sql = "INSERT INTO `register-info` (user_id, equip_identify, mac_address, sn,create_date) \
            #            VALUES (%s, '%s', '%s','%s','%s')" % \
            #           (user_id, equip_identify, mac_address, sn, create_date)
            #     print(sql)
            #     aa = cursor.execute(sql)
            #     db.commit()
            #
            #     resu = {'state': 0, 'message': "注册成功", 'user-class': "0", 'feature-list': "22"}
            #     return jsonify(resu)   # 将字典转换为json串, json是字符串
            # else:
            #     resu = {'state': 1, 'message': "该机器已经注册"}
            #     return jsonify(resu)   # 将字典转换为json串, json是字符串
        except Exception as e:
            resu = {'state': 1, 'message': e.args}
            return jsonify(resu)  # 将字典转换为json串, json是字符串
    else:
        resu = {'state': 1, 'message': '参数不能为空！'}

        return jsonify(resu)


@server.route('/unregister', methods=['post'])
def unregister():
    sn = request.values.get('sn')
    register_info = request.values.get('register-info')
    mac_address = request.values.get('mac-address')
    equip_identify = request.values.get('equip-identify')

    if not sn or not mac_address or not register_info:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)
    if not checkSN(sn):
        resu = {'state': 1, 'message': '序列号参数异常'}
        return jsonify(resu)
    if not checkMac(mac_address):
        resu = {'state': 1, 'message': 'Mac地址参数异常'}
        return jsonify(resu)

    sn = sn.strip().replace("-", "")
    mac_address = mac_address.strip().replace("-", "").replace(":", "").replace(".", "")

    try:
        db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT, use_unicode=True)
        cursor = db.cursor()

        try:
            register_info = json.loads(register_info)
            name = register_info["name"]
            legal_address = register_info["legal_address"]
            email_address = register_info["email_address"]
            contact_number = register_info["contact_number"]
            sql = "SELECT * FROM  `user` WHERE `name` = '%s'" % (name);
            num = cursor.execute(sql)
            result = cursor.fetchall();
            if num == 0:
                resu = {'state': 1, 'message': "找不到用户信息"}
                return jsonify(resu)  # 将字典转换为json串, json是字符串
            else:
                user_id = result[0][0]
        except:
            resu = {'state': 1, 'message': "用戶信息格式不正确，请检查register_info"}
            return jsonify(resu)  # 将字典转换为json串, json是字符串

        sql = "SELECT * FROM `grid`.`register-info` WHERE `sn` = '%s'" % (sn)
        num = cursor.execute(sql)
        if num == 0:
            resu = {'state': 1, 'message': "找不到已经注册的序列号"}
            return jsonify(resu)  # 将字典转换为json串, json是字符串
        else:
            result = cursor.fetchall()
            print(result[0])
            id = result[0][1]
            if id != user_id:
                resu = {'state': 1, 'message': "用户信息和已注册的用户信息不匹配"}
                return jsonify(resu)  # 将字典转换为json串, json是字符串

        sql = "DELETE FROM  `register-info` WHERE `sn` = '%s'" % (sn);
        num = cursor.execute(sql)

        db.commit()
        if (num != 0):
            resu = {'state': 0, 'message': "取消注册成功"}
            return jsonify(resu)  # 将字典转换为json串, json是字符串
        else:
            resu = {'state': 1, 'message': "找不到序列号"}
            return jsonify(resu)  # 将字典转换为json串, json是字符串

        sql = "DELETE FROM  `register-info` WHERE `mac_address` = '%s'" % (mac_address);
        print(sql)
        aa = cursor.execute(sql)
        db.commit()
        if (aa == 0):

            resu = {'state': 1, 'message': "找不到已经注册的信息", }
            return jsonify(resu)  # 将字典转换为json串, json是字符串
        else:
            resu = {'state': 0, 'message': "取消注册成功", }
            return jsonify(resu)  # 将字典转换为json串, json是字符串
    except:
        resu = {'state': 1, 'message': "数据库连接失败"}
        return jsonify(resu)  # 将字典转换为json串, json是字符串


@server.route('/', methods=['get'])
def root():
    return render_template("index.html")


def checkSN(sn):
    sn = sn.strip().replace("-", "")
    print(sn, len(sn))
    if len(sn) == 24 and re.match(r"^[A-Za-z0-9]+$", sn):
        return True
    return False


import re


def checkMac(mac):
    print(mac)
    mac = mac.strip().replace("-", "").replace(":", "").replace(".", "")
    if re.match(r"^\s*([0-9a-fA-F]{2,2}){5,5}[0-9a-fA-F]{2,2}\s*$", mac): return True
    return False


@server.route('/generateSNCode', methods=['get'])
def generateSNCode():
    return render_template("generateSNCode.html")


@server.route('/generateSNCode', methods=['post'])
def generateSNCodepost():
    sn = request.values.get('sn')
    areaCode = request.values.get("areaCode")
    distributorCode = request.values.get("distributorCode")
    ValidityPeriod = request.values.get("validityPeriod")
    EquipIdentify = request.values.get("equipIdentify")

    if not sn or not areaCode or not distributorCode or not ValidityPeriod:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)
    if not checkSN(sn):
        resu = {'state': 1, 'message': '序列号参数异常'}
        return jsonify(resu)

    resu = {'state': 0, 'message': '序列号添加成功'}
    return jsonify(resu)


@server.route('/checkregister', methods=['post'])
def checkregister():
    sn = request.values.get('sn')
    print(sn)
    macstrings = request.values.get('mac-array')
    print(macstrings)
    if not sn or not macstrings:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)
    if not checkSN(sn):
        resu = {'state': 1, 'message': '序列号参数异常'}
        return jsonify(resu)

    sn = sn.strip().replace("-", "")
    macs = macstrings.split(";")
    print(macstrings)
    checkmacis = False
    for mac in macs:
        if checkMac(mac):
            checkmacis = True
            break
    if not checkmacis:
        resu = {'state': 1, 'message': 'Mac地址参数异常'}
        return jsonify(resu)

    try:
        db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT, use_unicode=True)
        cursor = db.cursor()
        sql = "SELECT * FROM  `register-info` WHERE `sn` = '%s'" % (sn)
        print(sql)
        aa = cursor.execute(sql)
        print(aa)
        if (aa == 0):
            resu = {'state': 1, 'message': '找不到注册信息'}
            return jsonify(resu)  # 将字典转换为json串, json是字符串
        for row in cursor.fetchall():
            print(row[3])
            for mac in macs:
                if (row[3].strip().replace("-", "").replace(":", "").replace(".", "") == mac.strip().replace("-",
                                                                                                             "").replace(
                        ":", "").replace(".", "")):
                    resu = {'state': 0, 'message': '0'}
                    return jsonify(resu)  # 将字典转换为json串, json是字符串
        resu = {'state': 1, 'message': '当前序列号已注册到其他机器'}
        db.commit()
    except Exception:
        resu = {'state': 1, 'message': "数据库连接失败"}
    return jsonify(resu)  # 将字典转换为json串, json是字符串


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
    receivers = request.values.get('receivers')
    if not subject and not content and not receivers:
        resu = {'state': 1, 'message': '参数不能存在空值'}
        return jsonify(resu)

    smtp.receivers = receivers;
    code, msg = smtp.sendmail("subject", content)
    if code == 0:
        resu = {'state': code, 'message': msg}
        return jsonify(resu)
    else:
        resu = {'state': code, 'message': msg}
        return jsonify(resu)  # 将字典转换为json串, json是字符串


if __name__ == '__main__':
    server.run(port=18888, host='0.0.0.0',
               ssl_context=('v3.xincheng213618.com_bundle.crt', 'v3.xincheng213618.com.key'));
