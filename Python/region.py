import json

import pymysql.cursors

HOST = 'xc213618.ddns.me'
USER = 'root'
PASSWD = 'xincheng'
DB = 'grid'
PORT = 3306
CHARSET = 'utf8'

if __name__ == '__main__':
    with open("post.json", 'r',encoding="utf-8") as load_f:
        load_dict = json.load(load_f)
    db = pymysql.connect(host=HOST, user=USER, passwd=PASSWD, db=DB, charset=CHARSET, port=PORT,
                             use_unicode=True)
    for i in load_dict:
        print(i,load_dict[i])
        cursor = db.cursor()
        sql = "INSERT INTO  `region`(name, region_id)VALUES ('%s',%s)" % (load_dict[i],i);
        print(sql)
        aa = cursor.execute(sql)
        db.commit()
