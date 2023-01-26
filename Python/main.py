import flask, json
from flask import request
import time

import pymysql.cursors

HOST = 'xc213618.ddns.me'
USER = 'root'
PASSWD = 'xincheng'
DB = 'grid'
PORT = 3306
CHARSET = 'utf8'



'''
flask： web框架，通过flask提供的装饰器@server.route()将普通函数转换为服务
登录接口，需要传url、username、passwd
'''
# 创建一个服务，把当前这个python文件当做一个服务
server = flask.Flask(__name__)

# server.config['JSON_AS_ASCII'] = False
# @server.route()可以将普通函数转变为服务 登录接口的路径、请求方式
@server.route('/login', methods=['post'])
def login():
    # 获取通过url请求传参的数据
    username = request.values.get('name')
    # 获取url请求传的密码，明文
    pwd = request.values.get('pwd')
    # 判断用户名、密码都不为空，如果不传用户名、密码则username和pwd为None
    if username and pwd:
        if username == 'xiaoming' and pwd == '111':
            resu = {'code': 200, 'message': '登录成功'}
            return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
        else:
            resu = {'code': -1, 'message': '账号密码错误'}
            return json.dumps(resu, ensure_ascii=False)
    else:
        resu = {'code': 10001, 'message': '参数不能为空！'}
        return json.dumps(resu, ensure_ascii=False)



@server.route('/register1', methods=['post'])
def register1():
    username = request.values.get('userName')
    registrationDate =request.values.get('registrationDate')
    registeredAddress =request.values.get('registeredAddress')
    expirationDate =request.values.get('expirationDate')
    email =request.values.get('email')
    phoneNumber=request.values.get('phoneNumber')
    registerCode = request.values.get('registerCode')
    sn =request.values.get('sn')
    # 判断用户名、密码都不为空，如果不传用户名、密码则username和pwd为None
    if username and registerCode:
        try:
            db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                                 use_unicode=True)
            cursor = db.cursor()
            craet_time = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
            sql = 'INSERT INTO register(userName, registrationDate, registeredAddress, expirationDate, email,phoneNumber,registerCode,craet_time) \
                   VALUES ("%s", "%s", "%s","%s","%s","%s","%s","%s")' % \
                  (username, registrationDate, registeredAddress, expirationDate, email, phoneNumber, registerCode,
                   craet_time)
            print(sql)
            aa = cursor.execute(sql)
            db.commit();
            resu = {'code': 200, 'message': "保存成功"}
            return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
        except:
            resu = {'code': -1, 'message': "数据库连接失败"}
            return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
    else:
        resu = {'code': 10001, 'message': '参数为空'}
        return json.dumps(resu, ensure_ascii=False)


@server.route('/register', methods=['post'])
def register():
    user_id = 1 ;
    sn = request.values.get('sn')
    if (len(sn)!=24):
        resu = {'state': 1, 'message': "注册码位数异常"}
        return json.dumps(resu, ensure_ascii=False)


    register_info = request.values.get('register-info')
    mac_address = request.values.get('mac-address')
    equip_identify = request.values.get('equip-identify')

    if sn and register_info and mac_address and equip_identify:
        try:
            db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                                 use_unicode=True)
            cursor = db.cursor()

            sql = "SELECT * FROM  `register-info` WHERE `mac_address` = '%s'" %(mac_address);
            print(sql)
            aa = cursor.execute(sql)

            if (aa==0):
                create_date = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
                sql = "INSERT INTO `register-info` (user_id, equip_identify, mac_address, sn,create_date) \
                       VALUES (%s, '%s', '%s','%s','%s')" % \
                      (user_id, equip_identify, mac_address, sn, create_date)
                print(sql)
                aa = cursor.execute(sql)
                db.commit()

                resu = {'state': 0, 'message': "注册成功", 'user-class': "0", 'feature-list': "22"}
                return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
            else:
                resu = {'state': 1, 'message': "该用户已经注册"}
                return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
        except Exception as e:
            resu = {'state': 1, 'message': e.args}
            return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
    else:
        resu = {'state': 1, 'message': '参数不能为空！'}
        return json.dumps(resu, ensure_ascii=False)


@server.route('/unregister', methods=['post'])
def unregister():
    user_id = 1 ;
    sn = request.values.get('sn')
    register_info = request.values.get('register-info')
    mac_address = request.values.get('mac-address')
    equip_identify = request.values.get('equip-identify')

    if sn and register_info and mac_address and equip_identify:
        try:
            db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                                 use_unicode=True)
            cursor = db.cursor()

            sql = "DELETE FROM  `register-info` WHERE `mac_address` = '%s'" %(mac_address);
            print(sql)
            aa = cursor.execute(sql)
            db.commit()
            if (aa==0):
                resu = {'state': 0, 'message': "找不到已经注册的信息", }
                return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
            else:
                resu = {'state': 0, 'message': "取消注册成功", }
                return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
        except:
            resu = {'state': 1, 'message': "数据库连接失败"}
            return json.dumps(resu, ensure_ascii=False)  # 将字典转换为json串, json是字符串
    else:
        resu = {'state': 1, 'message': '参数不能为空！'}
        return json.dumps(resu, ensure_ascii=False)




def test1(user_id,equip_identify,mac_address,sn):
    db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                         use_unicode=True)
    cursor = db.cursor()
    create_date = time.strftime("%Y-%m-%d %H:%M:%S", time.localtime())
    sql = "INSERT INTO `register-info` (user_id, equip_identify, mac_address, sn,create_date) \
           VALUES (%s, '%s', '%s','%s','%s')" % \
          (user_id,equip_identify , mac_address, sn,create_date)
    print(sql)
    aa = cursor.execute(sql)
    db.commit();



if __name__ == '__main__':
    server.run(debug=True, port=18888, host='0.0.0.0',ssl_context=('v3.xincheng213618.com_bundle.crt', 'v3.xincheng213618.com.key'));