


import time

import pymysql.cursors

HOST = 'xc213618.ddns.me'
USER = 'root'
PASSWD = 'xincheng'
DB = 'grid'
PORT = 3306
CHARSET = 'utf8'


def mysqlconnect(sql):
    try:
        db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                             use_unicode=True)
        cursor = db.cursor()
        num =cursor.execute(sql)
        result =cursor.fetchall()
        db.commit()
        return num,result
    except Exception as e:
        return -1,e.args

